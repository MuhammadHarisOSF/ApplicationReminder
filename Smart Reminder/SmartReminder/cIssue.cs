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
    public class cIssue
    {
        public int pIssueID;
        public DateTime pIssueReportDate;
        public DateTime pIssueForwardDate;
        public DateTime pIssueResolvedDate;
        public String pRemarks;
        public String pReferance;
        public int pDepositSlipNo;
        public int pAccountNo;
        public int pChequeNo;
        public int pPayOrderNo;

        static SqlConnection adocon;

        static SqlCommand insertcmd;


        public static void fCreateIssue(cIssue tempIssue, cPayment tempPayment, cHBFCBranch tempHBFCBranch, cBank tempBank)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            String commandText = "insert into tblIssue values ('" + tempIssue.pIssueReportDate + "', '"
                                                                  + tempIssue.pIssueForwardDate + "', '"
                                                                  + tempIssue.pIssueResolvedDate + "', '"
                                                                  + tempBank.pBankName + "', '"
                                                                  + tempHBFCBranch.pHBFCBranchName + "', '"
                                                                  + tempPayment.pModeID + "', '"
                                                                  + tempIssue.pRemarks + "', '"
                                                                  + tempIssue.pReferance + "', '"
                                                                  + tempIssue.pDepositSlipNo + "', '"
                                                                  + tempIssue.pChequeNo + "', '"
                                                                  + tempIssue.pPayOrderNo + "')";

            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnTblBank(String query = "Select colBankName from tblBank")
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            insertcmd.CommandText = query;
            insertcmd.Connection = adocon;

            SqlDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static SqlDataReader fDataRetrieveOnlyColumnTblPayment(String query = "Select colModeName from tblPayment")
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            insertcmd.CommandText = query;
            insertcmd.Connection = adocon;

            SqlDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static SqlDataReader fDataRetrieveOnlyColumnTblHBFCBranch(String query = "Select colHBFCBranchName from tblHBFCBranch")
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            insertcmd.CommandText = query;
            insertcmd.Connection = adocon;

            SqlDataReader oDataReader = insertcmd.ExecuteReader();
            return oDataReader;
        }

        public static void fDataRetrieveWholeRecordTblIssue(cIssue tempIssue, cPayment tempPayment, cBank tempBank, cHBFCBranch tempHBFCBranch, String paraIssueID)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblIssue where colIssueID = '" + paraIssueID + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblIssue");
            DateTime.Now.ToShortDateString();
            tempIssue.pIssueID = Convert.ToInt16(oDataSet.Tables["tblIssue"].Rows[0]["colIssueID"].ToString());
            tempIssue.pIssueReportDate = Convert.ToDateTime(oDataSet.Tables["tblIssue"].Rows[0]["colIssueReportDate"].ToString());
            tempIssue.pIssueForwardDate = Convert.ToDateTime(oDataSet.Tables["tblIssue"].Rows[0]["colIssueForwardDate"].ToString());
            tempIssue.pIssueResolvedDate = Convert.ToDateTime(oDataSet.Tables["tblIssue"].Rows[0]["colIssueResolveDate"].ToString());
            tempBank.pBankName = oDataSet.Tables["tblIssue"].Rows[0]["colToBankName"].ToString();
            tempHBFCBranch.pHBFCBranchName = oDataSet.Tables["tblIssue"].Rows[0]["colFromHBFCBranchID"].ToString();
            tempPayment.pModeName = oDataSet.Tables["tblIssue"].Rows[0]["colModeID"].ToString();
            tempIssue.pRemarks = oDataSet.Tables["tblIssue"].Rows[0]["colRemarks"].ToString();
            tempIssue.pReferance = oDataSet.Tables["tblIssue"].Rows[0]["colRefNo"].ToString();
            tempIssue.pDepositSlipNo = Convert.ToInt16(oDataSet.Tables["tblIssue"].Rows[0]["colDepositSlipN"].ToString());
            tempIssue.pChequeNo = Convert.ToInt16(oDataSet.Tables["tblIssue"].Rows[0]["colChequeNo"].ToString());
            tempIssue.pPayOrderNo = Convert.ToInt16(oDataSet.Tables["tblIssue"].Rows[0]["colPayOrderNo"].ToString());
        }

        public static void fUpdateTblIssue(cIssue tempIssue, cPayment tempPayment, cBank tempBank, cHBFCBranch tempHBFCBranch)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            String commandText = "Update tblIssue set colIssueReportDate = '" + tempIssue.pIssueReportDate + "', ";
            commandText += " colIssueForwardDate = '" + tempIssue.pIssueForwardDate + "' ";
            commandText += " colIssueResolveDate = '" + tempIssue.pIssueReportDate + "' ";
            commandText += " colToBankName = '" + tempBank.pBankName + "' ";
            commandText += " colFromHBFCBranchID = '" + tempHBFCBranch.pHBFCBranchName + "' ";
            commandText += " colModeID = '" + tempPayment.pModeName + "' ";
            commandText += " colRemarks = '" + tempIssue.pRemarks + "' ";
            commandText += " colRefNo = '" + tempIssue.pReferance + "' ";
            commandText += " colDepositSlipNo = '" + tempIssue.pDepositSlipNo + "' ";
            commandText += " colChequeNo = '" + tempIssue.pChequeNo + "' ";
            commandText += " colPayOrderNo = '" + tempIssue.pPayOrderNo + "' ";

            commandText += " where colIssueID = '" + tempIssue.pIssueID + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fDeleteTblIssue(cIssue tempIssue)
        {
            adocon = new SqlConnection(cConnection.connectionString);


            String commandText = "delete from tblIssue where colIssueID = ";
            commandText += "'" + tempIssue.pIssueID + "'";



            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();

        }

        public static DataSet fGridViewIssue()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblIssue";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblIssue");
            return oDataSet;


        }
    }
}
