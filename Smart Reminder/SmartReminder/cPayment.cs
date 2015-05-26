using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SmartReminder
{
    public class cPayment
    {
        public int pModeID;
        public String pModeName;

        static SqlConnection adocon;
        static SqlCommand insertcmd;
        public static void fCreatePaymentMode(cPayment tempPayment)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "insert into tblPayment(colModeName) values ('" + tempPayment.pModeName + "')";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnPayment(String s = "Select colModeName from tblPayment")
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();
            insertcmd = new SqlCommand();
            insertcmd.CommandText = s;
            insertcmd.Connection = adocon;
            SqlDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static void fDataRetrieveWholeRecordPayment(cPayment tempPayment, String paraModeName)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblPayment where tblModeName = '" + paraModeName + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblPayment");

            tempPayment.pModeID = Convert.ToInt16(oDataSet.Tables["tblPayment"].Rows[0]["colModeID"].ToString());
            tempPayment.pModeName = oDataSet.Tables["tblPayment"].Rows[0]["colModeName"].ToString();
        }

        public static void fCRUD_U_Payment(cPayment tempPayment, String NameOfTheRecord)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            //update tStudent set name = 'aaa', FatherName='AAA', gpa='2' where name = 'owais'
            String commandText = "Update tblPayment set colModeName = '" + tempPayment.pModeName + "'";
            commandText += " where colModeName = '" + NameOfTheRecord + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fCRUD_D_Payment(cPayment tempPayment)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "delete from tblPayment where colModeName= ";
            commandText += "'" + tempPayment.pModeName + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }
        public static DataSet fGridView_Payment()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select colModeID as Payment_ID, colModeName AS Payment_Mode from tblPayment";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblPayment");
            return oDataSet;


        }
    }
}
