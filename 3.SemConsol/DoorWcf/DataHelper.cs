using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DoorWcf
{
    public class DataHelper
    {
        static string cstring =
            @"Server=tcp:apnelserv.database.windows.net,1433;Initial Catalog=Doortabase;Persist Security Info=False;User ID=apneljo;Password=1Langfedpik;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static Boolean addCard(Card composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "INSERT INTO CardTable(CardID) VALUES(@p1)";
                    cmd.Parameters.AddWithValue("@p1", composite.CardId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }


                }
            }
        }

        public static Boolean addDoor(Door composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "INSERT INTO DoorTable(DoorID) VALUES(@p1)";
                    cmd.Parameters.AddWithValue("@p1", composite.DoorId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }
                }
            }
        }

        public static Boolean EditCard(EditCard composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "UPDATE CardTable SET CardID = @p1 WHERE CardID = @p2";
                    cmd.Parameters.AddWithValue("@p1", composite.NewCardnr);
                    cmd.Parameters.AddWithValue("@p2", composite.OldCardnr);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }

                }
            }
        }

        public static Boolean EditDoor(EditDoor composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "UPDATE DoorTable SET DoorID = @p1 WHERE DoorID = @p2";
                    cmd.Parameters.AddWithValue("@p1", composite.NewDoornr);
                    cmd.Parameters.AddWithValue("@p2", composite.OldDoornr);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }

                }
            }
        }

        public static Boolean DeleteCard(Card composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "DELETE FROM CardTable WHERE CardID = @p1";
                    cmd.Parameters.AddWithValue("@p1", composite.CardId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }
                }
            }
        }

        public static Boolean DeleteDoor(Door composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "DELETE FROM DoorTable WHERE DoorID = @p1";
                    cmd.Parameters.AddWithValue("@p1", composite.DoorId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }
                }
            }
        }

        public static Boolean AddDoorAccess(DoorAccess composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "INSERT INTO DoorAccess(CardID, DoorID) VALUES(@p1, @p2)";
                    cmd.Parameters.AddWithValue("@p1", composite.CardId);
                    cmd.Parameters.AddWithValue("@p2", composite.DoorId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }
                }
            }
        }
        public static Boolean DeleteDoorAccess(DoorAccess composite)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    connectionstring.Open();
                    cmd.CommandText = "DELETE FROM DoorAccess WHERE CardID = @p1 and DoorID = @p2";
                    cmd.Parameters.AddWithValue("@p1", composite.CardId);
                    cmd.Parameters.AddWithValue("@p2", composite.DoorId);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectionstring;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    finally
                    {
                        connectionstring.Close();
                    }
                }
            }
        }

        public static List<Card> Cards()
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<Card> returnList = new List<Card>();
                connectionstring.Open();
                string sql = "SELECT * FROM CardTable";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Card c = new Card();
                    c.CardId = reader.GetString(0);
                    returnList.Add(c);
                }
                return returnList;

            }
        }
        public static List<Door> Doors()
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<Door> returnList = new List<Door>();
                connectionstring.Open();
                string sql = "SELECT * FROM DoorTable";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Door c = new Door();
                    c.DoorId = reader.GetInt32(0);
                    returnList.Add(c);
                }
                return returnList;

            }
        }
        public static List<DoorAccess> AccessList()
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<DoorAccess> returnList = new List<DoorAccess>();
                connectionstring.Open();
                string sql = "SELECT * FROM DoorAccess";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoorAccess c = new DoorAccess();
                    c.DoorId = reader.GetInt32(0);
                    c.CardId = reader.GetString(1);
                    returnList.Add(c);
                }
                return returnList;

            }
        }

        public static List<AccessLog> LogList()
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<AccessLog> returnList = new List<AccessLog>();
                connectionstring.Open();
                string sql = "SELECT * FROM AccessLog";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccessLog c = new AccessLog();
                    c.DoorId = reader.GetInt32(1);
                    c.CardId = reader.GetString(2);
                    c.DateTime = reader.GetString(4);
                    c.Access = reader.GetString(3);
                    returnList.Add(c);
                }
                return returnList;

            }
        }
        public static List<AccessLog> LogListOnCardId(string CardID)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<AccessLog> returnList = new List<AccessLog>();
                connectionstring.Open();
                string sql = "SELECT * FROM AccessLog WHERE CardId = @p1";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                cmd.Parameters.AddWithValue("@p1", CardID);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccessLog c = new AccessLog();
                    c.DoorId = reader.GetInt32(1);
                    c.CardId = reader.GetString(2);
                    c.DateTime = reader.GetString(4);
                    c.Access = reader.GetString(3);
                    returnList.Add(c);
                }
                return returnList;

            }
        }
        public static List<AccessLog> LogListOnDoorId(string DoorID)
        {
            using (SqlConnection connectionstring = new SqlConnection(cstring))
            {

                List<AccessLog> returnList = new List<AccessLog>();
                connectionstring.Open();
                string sql = "SELECT * FROM AccessLog WHERE DoorId = @p1";
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                cmd.Parameters.AddWithValue("@p1", DoorID);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AccessLog c = new AccessLog();
                    c.DoorId = reader.GetInt32(1);
                    c.CardId = reader.GetString(2);
                    c.DateTime = reader.GetString(4);
                    c.Access = reader.GetString(3);
                    returnList.Add(c);
                }
                return returnList;

            }
        }
    }
}