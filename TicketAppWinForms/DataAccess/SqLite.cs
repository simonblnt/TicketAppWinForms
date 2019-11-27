using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using TicketAppWinForms.Model;
using System.Linq;

namespace TicketAppWinForms.DataAccess
{
    static class SqLite
    {
        static readonly string dbFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TicketApp\SqLiteDbFiles\TicketApp_empty.sqlite";
        static readonly string connectionString = "Data Source=" + dbFileName + " ; Version = 3; New = True; Compress = True; ";
        static SQLiteConnection conn = new SQLiteConnection(connectionString);

        
        /// Public 
        
        //Init
        public static void Connect() {
            try
            {
                MessageBox.Show(dbFileName);
                Console.WriteLine();
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(1);
            }
        }

        public static void ClearData() {
            string sqlCreate = @"CREATE TABLE user (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                accountName varchar,
	                accountTypeId integer,
	                password varchar,
	                firstName varchar,
	                lastName varchar
                );

                CREATE TABLE accountType (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                name varchar,
	                isAdmin integer
                );

                CREATE TABLE match (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                teamHome varchar,
	                teamAway varchar,
	                income integer
                );

                CREATE TABLE ticket (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                matchId integer,
	                seatId integer,
	                ticketTypeId integer,
	                isSelected integer,
	                dateSelected datetime,
	                isOwned integer,
	                userId integer,
	                dateOwned datetime
                );

                CREATE TABLE seat (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                name varchar
                );

                CREATE TABLE ticketType (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                name varchar,
	                price integer
                );
                ";
            string sqlDrop = @"DROP TABLE IF EXISTS user;
                                DROP TABLE IF EXISTS accountType;
                                DROP TABLE IF EXISTS match;
                                DROP TABLE IF EXISTS ticket;
                                DROP TABLE IF EXISTS seat;
                                DROP TABLE IF EXISTS ticketType;";
            ExecuteQuery(sqlDrop);
            ExecuteQuery(sqlCreate);
        }

        public static void LoadDefaultData()
        {
            AddDefaultAccountTypes();
            AddDefaultUsers();
            AddDefaultTicketTypes();
            AddDefaultMatches();
        }

        public static void Disconnect()
        {
            conn.Close();
        }

        //Util
        public static bool IsConnected()
        {
            return conn.State == ConnectionState.Open;
        }

        public static bool IsLoginSuccessful(string username, string password)
        {
            string sql = @"SELECT 1 FROM user WHERE accountName='" + username + "' AND password='" + password + "';";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    if (cmd.ExecuteScalar() != null)
                        return true;
                    else
                        return false;
                }
            }
        }

        //Select
        public static List<Match> QueryListOfMatches() {
            List<Match> MatchList = new List<Match>();

            string sql = @"SELECT * FROM match";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MatchList.Add(new Match(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                        }
                    }
                }
            }

            return MatchList;
        }

        public static User QueryLoggedInUser(string username) {
            User user = null;
            string sql = @"SELECT * FROM user WHERE accountName='" + username + "';";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        }
                    }
                }
            }


            return user;
        }

        public static List<Seat> QuerySeats() {
            List<Seat> SeatList = new List<Seat>();

            string sql = @"SELECT * FROM seat";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SeatList.Add(new Seat(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
            }

            return SeatList;
        }

        //Insert
        public static void AddSeat(Seat seat) {
            string sql = @"INSERT INTO seat (name) VALUES ('" + seat.GetName().ToString() + "');";
            ExecuteQuery(sql);
        }

        //Update
        public static void SelectTicket(int seatId, int matchId)
        {
            string sql = @"UPDATE ticket SET isSelected = 1, dateSelected = (SELECT datetime('now')) WHERE seatId = " + seatId + " AND matchId = " + matchId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Non-Sql
        public static void GenerateTickets() {
            List<Seat> SeatList = QuerySeats();
            List<Match> MatchList = QueryListOfMatches();

            foreach (var match in MatchList)
            {
                foreach (var seat in SeatList)
                {
                    Ticket ticket = new Ticket
                    {
                        MatchId = match.Id,
                        SeatId = seat.Id
                    };
                    if (GetVIPSeatList().Contains(seat.GetName()))
                        ticket.TicketTypeId = 2;
                    else
                        ticket.TicketTypeId = 1;
                    AddTicket(ticket);
                }
            }
        }

        /// Private

        //Insert
        private static void AddTicket(Ticket ticket) {
            int matchId = ticket.MatchId;
            int seatId = ticket.SeatId;
            int ticketTypeId = ticket.TicketTypeId;
            string sql = @"INSERT INTO ticket (matchId, seatId, ticketTypeId, isSelected) VALUES (" + matchId + ", " + seatId + ", " + ticketTypeId + ", false);";
            ExecuteQuery(sql);
        }

        private static void AddDefaultAccountTypes() {
            string sql = @"INSERT INTO accountType (name, isAdmin) VALUES ('Normal', false), ('Admin', true);";
            ExecuteQuery(sql);
        }

        private static void AddDefaultUsers()
        {
            string sql = @"INSERT INTO user (accountName, accountTypeId, 
                password, firstName, lastName) VALUES ('vasarlo', 0, 'vasarlo1', 'Example', 'Customer'),
                                                       ('rendszergazda', 1, 'rendszergazda1', 'Example', 'Admin'),
                                                       ('a', 1, 'a', 'temp', 'user');";
            ExecuteQuery(sql);
        }

        private static void AddDefaultTicketTypes()
        {
            string sql = @"INSERT INTO ticketType (name, price) VALUES ('Normal', 15000), ('VIP', 50000);";
            ExecuteQuery(sql);
        }

        private static void AddDefaultMatches()
        {
            string sql = @"INSERT INTO match (teamHome, teamAway, income) 
                                VALUES ('Germany', 'England', 0),
                                       ('France', 'Sweden', 0),
                                       ('Hungary', 'Croatia', 0);";
            ExecuteQuery(sql);
        }

        //Util
        private static void ExecuteQuery(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        //Non-sql
        private static string[] GetVIPSeatList() {
            string[] vipList = { "A4", "B4", "C4",
                                "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10",
                                "L1", "M1", "N1",
                                "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10"};
            return vipList;
        }
    }
}
 
 
 