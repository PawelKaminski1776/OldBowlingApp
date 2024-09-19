using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PawelKaminskiProject
{
    class Bookings
    {
        private String Forename;
        private String Surname;
        private String Booking_Date;
        private String Booking_Time;
        private String Booking_Status;
        private double Booking_Cost;
        private int Booking_ID;
        private int Lane_ID;
        private int NumOfShoes;


        public Bookings()
        {
        }
        public Bookings(String Forename, String Surname, String Date, String Time, String Book_Status, int NumOfShoes, double Booking_Cost, int BookingID, int LaneID)
        {
            this.Forename = Forename;
            this.Surname = Surname;
            this.Booking_Date = Date;
            this.Booking_Time = Time;
            this.Booking_Status = Book_Status;
            this.NumOfShoes = NumOfShoes;
            this.Booking_Cost = Booking_Cost;
            this.Booking_ID = BookingID;
            this.Lane_ID = LaneID;
        }

        public void setBookingID(int bookingID) { Booking_ID = bookingID; }

        public void setLaneID(int laneID) { Lane_ID = laneID; }

        public void setForename(String forename) { Forename = forename; }

        public void setSurname(String surname) { Surname = surname; }

        public void seBookingDate(String bookingdate) {Booking_Date = bookingdate; }

        public void setBookingTime(String bookingtime) { Booking_Time = bookingtime; }

        public void setNumOfShoes(int numofshoes) { NumOfShoes = numofshoes; }

        public void setBookingCost(double bookingcost) { Booking_Cost = bookingcost; }


        public int getLane()
        {
            int Number;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Lane_ID FROM Bookings WHERE Booking_ID = '" + this.Booking_ID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            Number = dr.GetInt32(0);

            conn.Close();
            return Number;
        }

        public static int getNextBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(Booking_ID) FROM Bookings";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }

        public static int GetNextAvailableLane(string bookDate, int time)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "SELECT MIN(Lane_ID) FROM Lanes WHERE Lane_status = 'A' AND Lane_ID NOT IN " +
                              "(SELECT Lane_ID FROM Bookings WHERE Booking_Date = '" + bookDate + "' AND Booking_Time = " + time + ")";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId = 1;
            if (dr.Read() && !dr.IsDBNull(0))
            {
                nextId = dr.GetInt32(0);
            }
            else
            {
                Console.WriteLine("No available lanes for the specified booking date and time.");
            }

            conn.Close();

            return nextId;
        }

        public static int getNextAvailableShoes(int shoesize)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MIN(SlotNo) FROM PigeonHoles WHERE BookingRef = '0' OR BookingRef is null AND ShoeSize = '" + shoesize + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            nextId = dr.GetInt32(0);

            conn.Close();

            return nextId;
        }



        public void addBooking()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Bookings(Forename, Surname, Booking_Date, Booking_Time, Booking_Status, NumOfShoes, Booking_Cost, Booking_ID, Lane_ID)" +
                " VALUES('" + this.Forename + "','" + this.Surname + "','" + this.Booking_Date + "','" + this.Booking_Time +"','" + this.Booking_Status + "','" + this.NumOfShoes + "','" + this.Booking_Cost + "','" + this.Booking_ID + "','" + this.Lane_ID  + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static DataSet findBooking(String BookingName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Forename, Surname, Booking_Date, Booking_Time, Booking_Status, Booking_ID, Lane_ID, NumOfShoes, Booking_Cost FROM Bookings " +
                "WHERE Booking_ID LIKE '%" + BookingName + "%' ORDER BY Booking_ID";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }


        public static List<String> getAvailableShoes(List<String> list)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT ShoeSize FROM PigeonHoles WHERE BookingRef = '0' OR BookingRef is null";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
       
            while (dr.Read())
            {
                list.Add(dr[0].ToString());
            }
            
            dr.Close();
            conn.Close();

            return list;
        }


        public static List<String> getBooking_ID(List<String> list)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Booking_ID FROM Bookings WHERE Booking_Status = 'S' OR Booking_Status = 'B'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(dr[0].ToString());
            }

            dr.Close();
            conn.Close();

            return list;
        }

        
        public void UpdateBookingStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Bookings SET " + " Booking_Status = 'F' WHERE Booking_ID = '" + this.Booking_ID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateLaneStatus()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Lanes SET " + " Lane_Status = 'U' WHERE Lane_ID = '" + this.Lane_ID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void UpdateLane(String laneid, String status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Lanes SET " + " Status = '" + status + "' WHERE Lane_ID = '" + laneid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void UpdateShoesStatus(int shoeid, int bookingref)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE PigeonHoles SET " + " BookingRef = " + bookingref + " WHERE SlotNo = '" +  shoeid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Bookings SET " + " Forename = '" + this.Forename + "', Surname = '" + this.Surname + "', Booking_Date = '" + this.Booking_Date  + "', Booking_Time = '" + this.Booking_Time + "',NumOfShoes = '" + this.NumOfShoes + "',Booking_Cost = '" + this.Booking_Cost + "' WHERE Booking_ID = '" + this.Booking_ID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
  
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int GetNumberOfPeople(int bookingid)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT NumOfShoes FROM Bookings WHERE Booking_ID = '" + bookingid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            int answer=0;

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
          
            while (dr.Read())
            {
                answer = Convert.ToInt32(dr[0]);
            }

            conn.Close();

            return answer;

        }

        public static void deleteBooking(int bookingid)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "DELETE FROM Bookings WHERE Booking_ID = '" + bookingid + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
