using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.DataAccess
{
    static class SqLite
    {
        const string dbFileName = @"TicketApp_empty.sqlite";
        static SQLiteConnection conn = new SQLiteConnection("Data Source=" + dbFileName + " ; Version = 3; New = True; Compress = True; ");

        public static void Connect() {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Environment.Exit(1);
            }
        }

        public static void ClearData() {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"DROP TABLE IF EXISTS user;
                                DROP TABLE IF EXISTS accountType;
                                DROP TABLE IF EXISTS match;
                                DROP TABLE IF EXISTS ticket;
                                DROP TABLE IF EXISTS location;
                                DROP TABLE IF EXISTS ticketType;";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE user (
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
	                locationId integer,
	                ticketTypeId integer,
	                isSelected integer,
	                dateSelected datetime,
	                isOwned integer,
	                userId integer,
	                dateOwned datetime
                );

                CREATE TABLE location (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                name varchar
                );

                CREATE TABLE ticketType (
	                id integer PRIMARY KEY AUTOINCREMENT,
	                name varchar,
	                price integer
                );
                ";
            cmd.ExecuteNonQuery();
        }

        public static void LoadDefaultData()
        {
            AddDefaultAccountTypes();
            AddDefaultUsers();
            AddDefaultTicketTypes();
            AddDefaultMatches();
        }

        public static bool IsLoginSuccessful(string username, string password)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT 1 FROM user WHERE accountName='" + username + "' AND password='" + password + "';";

            if (cmd.ExecuteScalar() != null)
                return true;
            else
                return false;
        }

        public static List<Match> QueryListOfMatches() {
            List<Match> MatchList = new List<Match>();

            string query = @"SELECT * FROM match";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //MessageBox.Show((Int32)reader.GetInt32(0) + reader.GetString(1).ToString() + reader.GetString(2).ToString() + (Int32)reader.GetInt32(3));
                    MatchList.Add(new Match(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
            }

            return MatchList;
        }

        public static User QueryLoggedInUser(string username) {
            User user = null;

            string query = @"SELECT * FROM user WHERE accountName='" + username + "';";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    
                    user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }


            return user;
        }

        

        public static void Disconnect() {
            conn.Close();
        }




        private static void AddDefaultAccountTypes() {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO accountType (name, isAdmin) VALUES ('Normal', false);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO accountType (name, isAdmin) VALUES ('Admin', true);";
            cmd.ExecuteNonQuery();
        }

        private static void AddDefaultUsers()
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO user (accountName, accountTypeId, 
                password, firstName, lastName) VALUES ('vasarlo', 0, 'vasarlo1', 'Example', 'Customer');";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO user (accountName, accountTypeId, 
                password, firstName, lastName) VALUES ('rendszergazda', 1, 'rendszergazda1', 'Example', 'Admin');";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO user (accountName, accountTypeId, 
                password, firstName, lastName) VALUES ('a', 1, 'a', 'temp', 'user');";
            cmd.ExecuteNonQuery();
        }

        private static void AddDefaultTicketTypes()
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO ticketType (name, price) VALUES ('Normal', 15000);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO ticketType (name, price) VALUES ('VIP', 50000);";
            cmd.ExecuteNonQuery();
        }

        private static void AddDefaultMatches()
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO match (teamHome, teamAway, income) VALUES ('Germany', 'England', 0);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO match (teamHome, teamAway, income) VALUES ('France', 'Sweden', 0);";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"INSERT INTO match (teamHome, teamAway, income) VALUES ('Hungary', 'Croatia', 0);";
            cmd.ExecuteNonQuery();
        }
    }
}
 
 
 