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
    public class cDepartment
    {
        public int pDepartmentID;
        public String pDepartmentName;

        static SqlConnection adocon;
        static SqlCommand insertcmd;

        public static void fCreateDepartment(cDepartment tempDepartment)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "insert into tblDepartment(colDepartmentName) values ('" + tempDepartment.pDepartmentName + "')";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnDepartment(String s = "Select colDepartmentName from tblDepartment")
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

        public static void fDataRetrieveWholeRecordDepartment(cDepartment tempDepartment, String paraDepartmentName)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblDepartment where colDepartmentName = '" + paraDepartmentName + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblDepartment");

            tempDepartment.pDepartmentID = Convert.ToInt16(oDataSet.Tables["tblDepartment"].Rows[0]["colDepartmentID"].ToString());
            tempDepartment.pDepartmentName = oDataSet.Tables["tblDepartment"].Rows[0]["colDepartmentName"].ToString();
        }

        public static void fCRUD_U_Department(cDepartment tempDepartment, String NameOfTheRecord)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "Update tblDepartment set colDepartmentName = '" + tempDepartment.pDepartmentName + "'";
            commandText += " where colDepartmentName = '" + NameOfTheRecord + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fCRUD_D_Department(cDepartment tempDepartment)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            String commandText = "delete from tblDepartment where colDepartmentName= ";
            commandText += "'" + tempDepartment.pDepartmentName + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);
            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();
            insertcmd.Connection.Close();
        }
        public static DataSet fGridView_Department()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select colDepartmentID as Department_ID, colDepartmentName AS Department_Name from tblDepartment";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblDepartment");
            return oDataSet;
        }
    }
}
