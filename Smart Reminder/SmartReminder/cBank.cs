using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace SmartReminder
{
    public class cBank
    {
        public int pBankID;// hello
        public String pBankName;

        static SqlConnection adocon;
        static SqlCommand insertcmd;
        public static void fCreateBank(cBank tempBank)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "insert into tblBank(colBankName) values ('" + tempBank.pBankName + "')";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnBank(String s = "Select colBankName from tblBank")
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

        public static void fDataRetrieveWholeRecordBank(cBank tempBank, String paraBankName)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblBank where colBankName = '" + paraBankName + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblBank");

            tempBank.pBankID = Convert.ToInt16(oDataSet.Tables["tblBank"].Rows[0]["colBankID"].ToString());
            tempBank.pBankName = oDataSet.Tables["tblBank"].Rows[0]["colBankName"].ToString();
        }

        public static void fCRUD_U_Bank(cBank tempBank, String NameOfTheRecord)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            //update tStudent set name = 'aaa', FatherName='AAA', gpa='2' where name = 'owais'
            String commandText = "Update tblBank set colBankName = '" + tempBank.pBankName + "'";
            commandText += " where colBankName = '" + NameOfTheRecord + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fCRUD_D_Bank(cBank tempBank)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "delete from tblBank where colBankName= ";
            commandText += "'" + tempBank.pBankName + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }
        public static DataSet fGridView_Bank()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select colBankID as Bank_ID, colBankName AS Bank_Name from tblBank";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblBank");
            return oDataSet;


        }
    }
}
