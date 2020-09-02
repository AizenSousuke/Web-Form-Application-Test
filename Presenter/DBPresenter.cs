using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationTest.Presenter
{
    public class DBPresenter
    {
        public string ConnectionString;
        SqlConnection sqlConnection;
        SqlCommand command;

        public DBPresenter()
        {
            ConnectionString = @"Data Source=THEACCELERATOR; Initial Catalog = Test;Trusted_Connection=True";
        }

        public double GetData()
        {
            var data = (double)0;
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            String cmd = "Select Cash from Cashier where ID = 1";
            command = new SqlCommand(cmd, sqlConnection);
            command.ExecuteNonQuery();
            using (SqlDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    Double.TryParse(rdr["Cash"].ToString(), out data);
                }
            }
            sqlConnection.Close();
            return data;
        }

        public void AddData(double value)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            double oldvalue = GetData();
            double newvalue = oldvalue + value;

            sqlConnection.Open();
            //String.Format()
            String cmd = @"update Cashier set cash = " + newvalue.ToString() + @" where ID = 1";
            command = new SqlCommand(cmd, sqlConnection);
            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

    }
}