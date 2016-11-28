using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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

            return true;
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

            return true;
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
    }
}