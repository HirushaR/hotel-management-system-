using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Guest
    {
        private string FirstName;
        private string LastName;
        private string Designation;

        public void SetFirstName(string firstname)
        {
            FirstName = firstname;
        }
        public void SetLastName(string lastname)
        {
            LastName = lastname;
        }
        public void SetDesignation(string designation)
        {
            Designation = designation;
        }

        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetDesignation()
        {
            return Designation;
        }



        public static Guest CustomerNameByRoomNumber(string roomNumber)
        {
            SqlDataReader reader = null; // this is null because of the try/catch block.
            SqlConnection connection = db.GetConnection();
            Guest guest = new Guest();
            try
            {
                string queryGuestId = $"SELECT * FROM guestRooms WHERE room_number = '{roomNumber}'";
                SqlCommand cmd = new SqlCommand(queryGuestId, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                string guestId = null;
                while (reader.Read())
                {
                    guestId = reader["guest_id"].ToString();
                }
                reader.Close();
                string queryGuestDetails = $"SELECT designation,fname,lname FROM guests WHERE Id={guestId}";
                cmd = new SqlCommand(queryGuestDetails, connection);
                reader = cmd.ExecuteReader();
                string designation = null, firstName = null, lastName = null;
                while (reader.Read())
                {
                    designation = reader["designation"].ToString().Trim();
                    firstName = reader["fname"].ToString().Trim();
                    lastName = reader["lname"].ToString().Trim();
                }

                

                guest.SetFirstName(firstName);
                guest.SetLastName(lastName);
                guest.SetDesignation(designation);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }
            }

            return guest;
        }

    }
}
