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
	                isOwned integer,
	                userId integer
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

        //Select - Queries
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

        public static string QueryUserName(int userId)
        {
            string sql = @"SELECT accountName FROM user WHERE id = " + userId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string userName = "";
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                userName = reader.GetString(0);
                            }
                            return userName;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static string QueryUserFullName(int userId)
        {
            string sql = @"SELECT firstName, lastName FROM user WHERE id = " + userId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string fullName = "";
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                fullName = reader.GetString(0) + " " + reader.GetString(1);
                            }
                            return fullName;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
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

        public static List<TicketType> QueryTicketTypes()
        {
            List<TicketType> TicketTypes = new List<TicketType>();

            string sql = @"SELECT * FROM ticketType;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TicketTypes.Add(new TicketType(reader.GetInt32(0),
                                                            reader.GetString(1),
                                                            reader.GetInt32(2)));
                        }
                    }
                }
            }

            return TicketTypes;
        }

        public static string QuerySeatName(int seatId)
        {
            string sql = @"SELECT name FROM seat WHERE id = " + seatId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string seatName = "";
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                seatName = reader.GetString(0);
                            }
                            return seatName;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static string QueryTicketTypeName(int ticketTypeId)
        {
            string sql = @"SELECT name FROM ticketType WHERE id = " + ticketTypeId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string ticketTypeName = "";
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ticketTypeName = reader.GetString(0);
                            }
                            return ticketTypeName;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static int QueryNumberOfTicketsByType(int matchId, int ticketTypeId)
        {
            int count = 0;

            string sql = @"SELECT id FROM ticket WHERE matchId= " + matchId +" AND ticketTypeId= " + ticketTypeId + " AND isOwned = true;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public static int QueryTicketPrice(int ticketTypeId)
        {
            string sql = @"SELECT price FROM ticketType WHERE id = " + ticketTypeId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int ticketPrice = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ticketPrice = reader.GetInt32(0);
                            }
                            return ticketPrice;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }

        public static int QueryTicketOwnerId(int ticketId)
        {
            string sql = @"SELECT userId FROM ticket WHERE id = " + ticketId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int ownerId = 0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ownerId = reader.GetInt32(0);
                            }
                            return ownerId;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }

        public static List<Ticket> QuerySelectedTickets(int matchId, int userId)
        {
            List<Ticket> SelectedTickets = new List<Ticket>();
            string sql = @"SELECT * FROM ticket WHERE matchId = " + matchId + "" +
                                                " AND userId = " + userId + "" +
                                                " AND isSelected = true;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bool isSelected, isOwned;
                                if (reader.GetInt32(4) == 1)
                                    isSelected = true;
                                else
                                    isSelected = false;

                                if (reader.GetInt32(6) == 1)
                                    isOwned = true;
                                else
                                    isOwned = false;

                                SelectedTickets.Add(new Ticket(reader.GetInt32(0),                  //id
                                                               reader.GetInt32(1),                  //matchId
                                                               reader.GetInt32(2),                  //seatId
                                                               reader.GetInt32(3),                  //ticketTypeId
                                                               isSelected,                          //isSelected
                                                               isOwned,                             //isOwned
                                                               reader.GetInt32(6)));                //userId
                            }
                        }
                        
                    }
                }
            }
            return SelectedTickets;
        }

        public static List<Ticket> QueryOwnedTickets(int matchId)
        {
            List<Ticket> OwnedTickets = new List<Ticket>();
            string sql = @"SELECT * FROM ticket WHERE isOwned = true AND matchId = " + matchId + ";";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bool isSelected, isOwned;
                                if (reader.GetInt32(4) == 1)
                                    isSelected = true;
                                else
                                    isSelected = false;

                                if (reader.GetInt32(6) == 1)
                                    isOwned = true;
                                else
                                    isOwned = false;

                                OwnedTickets.Add(new Ticket(reader.GetInt32(0),                  //id
                                                               reader.GetInt32(1),                  //matchId
                                                               reader.GetInt32(2),                  //seatId
                                                               reader.GetInt32(3),                  //ticketTypeId
                                                               isSelected,                          //isSelected
                                                               isOwned,                             //isOwned
                                                               reader.GetInt32(6)));                //userId
                            }
                        }

                    }
                }
            }
            return OwnedTickets;
        }

        public static int QueryMatchId(string homeTeam, string awayTeam)
        {
            string sql = @"SELECT id FROM match WHERE teamHome= '" + homeTeam + "' AND teamAway= '" + awayTeam + "';";
            int id = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = reader.GetInt32(0);
                            }
                            return id;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }

        public static int QueryMatchIncome(int id)
        {
            string sql = @"SELECT income FROM match WHERE id= " + id + ";";
            int income = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                income = reader.GetInt32(0);
                            }
                            return income;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }



        public static int CalculateMatchIncome(int matchId)
        {
            List<int> TicketTypeId = new List<int>();
            int matchIncome = 0;
            string sql = @"SELECT ticketTypeId FROM ticket WHERE matchId= " + matchId + " AND isOwned=1 ;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TicketTypeId.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
            }

            foreach (var ticketTypeId in TicketTypeId)
            {
                matchIncome += QueryTicketPrice(ticketTypeId);
            }

            return matchIncome;
        }

        //Select - Booleans
        public static bool IsAdmin(int userId)
        {
            string sql = @"SELECT id FROM user WHERE id= " + userId + " AND accountTypeId = 1;";
            return HasRows(sql);
        }

        public static bool IsTicketSelected(int seatId, int matchId)
        {
            string sql = @"SELECT id FROM ticket WHERE seatId =" + seatId + " AND matchId =" + matchId + " AND isSelected = true;";

            return HasRows(sql);
        }

        public static bool IsTicketSelectedByUser(int seatId, int matchId, int userId)
        {
            string sql = @"SELECT id FROM ticket WHERE seatId= " + seatId + " " +
                " AND userId= " + userId + " " + "" +
                " AND matchId= " + matchId + " " +
                " AND isSelected = true;";

            return HasRows(sql);
        }

        public static bool IsTicketOwned(int seatId, int matchId)
        {
            string sql = @"SELECT id FROM ticket WHERE seatId =" + seatId + " AND matchId =" + matchId + " AND isOwned = true;";

            return HasRows(sql);
        }

        public static bool IsTicketOwnedByUser(int seatId, int matchId, int userId)
        {
            string sql = @"SELECT id FROM ticket WHERE seatId= " + seatId + "" +
                " AND userId= " + userId + "" +
                " AND isOwned = true" +
                " And matchId = " + matchId + ";";

            return HasRows(sql);
        }

        public static bool IsSeatAdded(string seatName)
        {
            string sql = @"SELECT id FROM seat WHERE name= '" + seatName + "';";

            return HasRows(sql);
        }

        //Insert
        public static void AddSeat(Seat seat) {
            string sql = @"INSERT INTO seat (name) VALUES ('" + seat.GetName().ToString() + "');";
            ExecuteQuery(sql);
        }

        //Update
        public static void SelectTicket(int seatId, int matchId, int userId)
        {
            string sql = @"UPDATE ticket SET isSelected = 1, userId = " + userId + "" +
                                " WHERE seatId = " + seatId + " AND matchId = " + matchId + ";";
            ExecuteQuery(sql);
        }

        public static void UnselectTicket(int seatId, int matchId)
        {
            string sql = @"UPDATE ticket SET isSelected = 0, userId = null
                                  WHERE seatId = " + seatId + " AND matchId = " + matchId + ";";
            ExecuteQuery(sql);
        }

        public static void UpdateUser(int userId, string firstName, string lastName)
        {
            string sql = @"UPDATE user SET firstName ='" + firstName + "', lastName ='" + lastName + "' " +
                            "WHERE id= " + userId + ";";
            ExecuteQuery(sql);
        }

        public static void BuyTicket(int seatId, int matchId)
        {
            string sql = @"UPDATE ticket SET isSelected = 0,
                                            isOwned = true " +
                                         " WHERE seatId = " + seatId + " " +
                                            "AND matchId = " + matchId + ";";
            ExecuteQuery(sql);
        }

        public static void IncreaseIncome(int amount, int matchId)
        {
            string sql = @"UPDATE match SET income = income + " + amount + " WHERE id = " + matchId + ";";
            ExecuteQuery(sql);
        }

        public static void ClearSelection(int userId, int matchId)
        {
            string sql = @"UPDATE ticket SET isSelected = 0, userId = null
                                  WHERE userId = " + userId + " AND matchId = " + matchId + " AND isSelected = 1;";
            ExecuteQuery(sql);
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

        private static bool HasRows(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }
        
        //Non-sql
        public static string[] GetVIPSeatList() {
            string[] vipList = { "A4", "B4", "C4",
                                "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10",
                                "L1", "M1", "N1",
                                "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10"};
            return vipList;
        }
    }
}
 
 
 