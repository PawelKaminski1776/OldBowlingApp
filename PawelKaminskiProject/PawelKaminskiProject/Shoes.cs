using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PawelKaminskiProject
{
    class Shoes
    {
        private int shoeID;
        private int shoeSize;
        private int bookingref;
        private int quantity;

        public Shoes()
        {
            this.shoeID = 0;
            this.shoeSize = 0;
        }

        public Shoes(int shoeID, int shoeSize, int quantity)
        {
            this.shoeID = shoeID;
            this.shoeSize = shoeSize;
            this.quantity = quantity;
        }

        public int getShoeID() { return this.shoeID; }
        public int getShoeSize() { return this.shoeSize; }

        public int getBookingRef() { return this.bookingref; }

        public void setShoeID(int ShoeID) { shoeID = ShoeID; }
        public void setShoeSize(int ShoeSize) { shoeSize = ShoeSize; }

        public void setBookingRef(int bookingRef) { bookingRef = bookingref; }


        public void UpdateShoesSize()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE PigeonHoles SET " + " ShoeSize = '" + this.shoeSize + "' WHERE SlotNo = '" + this.shoeID + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void UpdateShoesStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE PigeonHoles SET " + " BookingRef = '" + this.bookingref + "' WHERE  SlotNo = '" + this.shoeID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public static DataSet findShoes(String shoeName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT SlotNo, BookingRef, ShoeSize FROM PigeonHoles " +
                "WHERE SlotNo = " + shoeName + " ORDER BY SlotNo";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }

        public void UpdatePigeonHoles(List<int> list)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                conn.Open();

                for (int i = 0; i < list.Count; i++)
                {
                    string sqlQuery = "UPDATE PigeonHoles SET " + " ShoeSize = '" + this.shoeSize + "' WHERE SlotNo = '" + list[i] + "'";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding shoes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void addShoes(List<int> list)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            try
            {
                conn.Open();

                for (int i = 0; i < list.Count; i++)
                {
                    string sqlQuery = "INSERT INTO PigeonHoles(SlotNo, ShoeSize, BookingRef) VALUES(" + list[i] + ",'" + this.shoeSize + "', null)";

                    OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding shoes: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<int> getExistingSlots(List<int> list)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT SlotNo FROM PigeonHoles WHERE ShoeSize IS null OR ShoeSize = '0'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add(Convert.ToInt32(dr[0].ToString()));
            }

            dr.Close();
            conn.Close();

            return list;
        }

        public static int getNextShoes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(SlotNo) FROM PigeonHoles";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }
    }
}
