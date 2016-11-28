using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemConsol
{
    public class DBMapper
    {
        private static string connectionstring = @"Data Source=apnelserv.database.windows.net;Initial Catalog=Doortabase;Integrated Security=False;User ID=apneljo;Password=1Langfedpik;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Door> ListOfDoors()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                List<Door> tobereturned = new List<Door>();

                string queryString = "SELECT DoorTable.DoorID FROM DoorTable";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Door d = new Door();
                    d.DoorID = reader.GetInt32(0);
                    tobereturned.Add(d);
                }
                return tobereturned;
            }
        }
        public static List<Card> ListOfCards()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                List<Card> tobereturned = new List<Card>();

                string queryString = "SELECT CardTable.CardID FROM CardTable";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Card c = new Card();
                    c.CardID = reader.GetString(0);
                    tobereturned.Add(c);
                }
                return tobereturned;
            }
        }
        public static List<Access> ListOfAccess()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                List<Access> tobereturned = new List<Access>();

                string queryString = "SELECT * FROM DoorAccess";
                SqlCommand cmd = new SqlCommand(queryString, connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Access a = new Access();
                    a.DoorAccessID = reader.GetInt32(0);
                    a.CardID = reader.GetString(1);
                    tobereturned.Add(a);
                    
                }
                return tobereturned;
            }
        }

        private static void AccessLogs(Access h)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO DATA (LogID, DoorID, CardID, Access, TimeDate) VALUES (@LogID, @DoorID, @CardID, @Access, @TimeDate)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@DoorID", Door)


            }   
        }
    }
}
