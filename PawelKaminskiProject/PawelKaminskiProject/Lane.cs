using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PawelKaminskiProject
{
    class Lane
    {
        private int Lane_ID;
        private String Lane_Status;

        public Lane()
        {
            this.Lane_ID = 000;
            this.Lane_Status = "";
        }

        public Lane(int Lane_ID, String Lane_Status)
        {
            this.Lane_ID = Lane_ID;
            this.Lane_Status = Lane_Status;
        }

        public int getLaneID() { return this.Lane_ID; }
        public String getLaneStatus() { return this.Lane_Status; }

        public void setLaneID(int LaneID) { Lane_ID = LaneID; }
        public void setLaneStatus(String LaneStatus) { Lane_Status = LaneStatus; }

        public void getLane(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Lanes WHERE Lane_ID = " + Id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setLaneID(dr.GetInt32(0));
            setLaneStatus(dr.GetString(1));


            conn.Close();
        }

        public void addLane()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Lanes(Lane_Status, Lane_ID) VALUES('" + this.Lane_Status + "','" + this.Lane_ID + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateLane()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Lanes SET " + " Lane_Status = '" + this.Lane_Status + "' WHERE Lane_ID = '" + this.Lane_ID + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findLane(String laneName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Lane_ID, Lane_Status FROM Lanes " +
                "WHERE Lane_ID LIKE '%" + laneName + "%' ORDER BY Lane_ID";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            conn.Close();

            return ds;
        }

        public static int getNextLane()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(Lane_ID) FROM Lanes";

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
    }
}

