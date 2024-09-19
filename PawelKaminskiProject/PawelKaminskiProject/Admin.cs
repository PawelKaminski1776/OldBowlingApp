using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelKaminskiProject
{
    class Admin
    {
        private int Booking_Year;
        private double Total_Revenue;
        private int Total_Bookings;

        public Admin()
        {
        }

        public Admin(int Booking_Year, double Total_Revenue, int Total_Bookings)
        {
            this.Booking_Year = Booking_Year;
            this.Total_Revenue = Total_Revenue;
            this.Total_Bookings = Total_Bookings;
        }

        public void setBookingYear(int BookingYear) { Booking_Year = BookingYear; }
        public void setTotalRevenue(double TotalRevenue) { Total_Revenue = TotalRevenue; }

        public void setTotalBookings(int TotalBookings) { Total_Bookings = TotalBookings; }
        public static List<String> getYears(List<String> list)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT EXTRACT(Year FROM BOOKING_DATE) FROM Bookings";

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

        public static int GetMonthlyBookings(String Month, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT COUNT(*) FROM Bookings WHERE BOOKING_DATE LIKE '%" + Month + "-" + Year + "%' AND Booking_Status = 'F' OR Booking_Status = 'B'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            int answer = 0;

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0] != DBNull.Value)
                {
                    answer = Convert.ToInt32(dr[0]);
                }
                else
                {
                    answer = 0;
                }
            }

            conn.Close();

            return answer;

        }

        public static int GetMonthlyRevenue(String Month, String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT SUM(Booking_Cost) FROM Bookings WHERE BOOKING_DATE LIKE '%" + Month + "-" + Year + "%' AND Booking_Status = 'F' OR Booking_Status = 'B'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            int answer = 0;

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if(dr[0] != DBNull.Value)
                {
                    answer = Convert.ToInt32(dr[0]);
                }
                else
                {
                    answer = 0;
                }
            }

            conn.Close();

            return answer;

        }



        public void addAdmin()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Admin(Booking_Year, Total_Revenue, Total_Bookings)" +
                " VALUES('" + this.Booking_Year + "','" + this.Total_Revenue + "','" + this.Total_Bookings + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void UpdateAdmin()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Admin SET " + "Total_Revenue = '" + this.Total_Revenue + "' ,Total_Bookings = '" + this.Total_Bookings + "' WHERE Booking_Year = '" + this.Booking_Year + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<String> getBooking_Year(List<String> list)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Booking_Year FROM Admin";

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

    }
}
