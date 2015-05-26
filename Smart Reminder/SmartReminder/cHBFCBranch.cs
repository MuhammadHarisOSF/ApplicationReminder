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
    public class cHBFCBranch
    {
        public int pHBFCBranchID;
        public String pHBFCBranchName;

        static SqlConnection adocon;
        static SqlCommand insertcmd;
        public static void fCreateHBFCBranch(cHBFCBranch tempHBFCBranch)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "insert into tblHBFCBranch values ('" + tempHBFCBranch.pHBFCBranchID + "','" + tempHBFCBranch.pHBFCBranchName + "')";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnHBFCBranch(String s = "Select colHBFCBranchName from tblHBFCBranch")
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

        public static void fDataRetrieveWholeRecordHBFCBranch(cHBFCBranch tempHBFCBranch, String paraHBFCBranch)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblHBFCBranch where colHBFCBranchName = '" + paraHBFCBranch + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblHBFCBranch");

            tempHBFCBranch.pHBFCBranchID = Convert.ToInt16(oDataSet.Tables["tblHBFCBranch"].Rows[0]["colHBFCBranchID"].ToString());
            tempHBFCBranch.pHBFCBranchName = oDataSet.Tables["tblHBFCBranch"].Rows[0]["colHBFCBranchName"].ToString();
        }

        public static void fCRUD_U_HBFCBranch(cHBFCBranch tempHBFCBranch, String NameOfTheRecord)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "Update tblHBFCBranch set colHBFCBranchName = '" + tempHBFCBranch.pHBFCBranchName + "'";
            commandText += " where colHBFCBranchName = '" + NameOfTheRecord + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }

        public static void fCRUD_D_HBFCBranch(cHBFCBranch tempHBFCBranch)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "delete from tblHBFCBranch where colHBFCBranchName= ";
            commandText += "'" + tempHBFCBranch.pHBFCBranchName + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }
        public static DataSet fGridView_HBFCBranch()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();
            insertcmd = new SqlCommand();
            String vCommandText = "Select colHBFCBranchID as HBFC_Branch_Code, colHBFCBranchName AS HBFC_Branch_Name from tblHBFCBranch";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;
            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;
            DataSet oDataSet = new DataSet();
            oAdapter.Fill(oDataSet, "tblHBFCBranch");
            return oDataSet;


        }
    }
}
