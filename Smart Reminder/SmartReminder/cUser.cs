using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Security.Cryptography;

namespace SmartReminder
{
    public class cUser
    {
        public String pUsername;
        public String pPassword;
        public String pType;
        public String pDepartment;
        public String pTempPassword;

        static SqlConnection adocon;

        static SqlCommand insertcmd;


        public static void fCreateUser(cUser tempUser)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            String commandText = "insert into tblUser values ('" + tempUser.pUsername + "', '"
                                                                  + tempUser.pPassword + "', '"
                                                                  + "limited" + "', '"
                                                                  + tempUser.pDepartment + "')";

            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static SqlDataReader fDataRetrieveOnlyColumnTblUser(String query = "Select colUserName from tblUser")
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

        public static void fDataRetrieveWholeRecordTblUser(cUser tempUser, String paraUserName)
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblUser where colUserName = '" + paraUserName + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblUser");

            tempUser.pUsername = oDataSet.Tables["tblUser"].Rows[0]["colUserName"].ToString();
            tempUser.pPassword = oDataSet.Tables["tblUser"].Rows[0]["colPassword"].ToString();


        }

        public static void fUpdateTblUser(cUser tempUser)
        {
            adocon = new SqlConnection(cConnection.connectionString);

            String commandText = "Update tblUser set colUsername = '" + tempUser.pUsername + "', ";
            commandText += " colpassword = '" + tempUser.pPassword + "' ";

            commandText += " where colUserName = '" + tempUser.pUsername + "'";
            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();
        }

        public static void fDeleteTblUser(cUser tempUser)
        {
            adocon = new SqlConnection(cConnection.connectionString);


            String commandText = "delete from tblUser where colUserName = ";
            commandText += "'" + tempUser.pUsername + "'";



            SqlCommand insertcmd = new SqlCommand(commandText, adocon);

            insertcmd.Connection.Open();
            insertcmd.ExecuteNonQuery();

            insertcmd.Connection.Close();

        }

        public String conversion(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public static void fDataRetrievePassWord(cUser tempUser, String paraUserName)
        {
            adocon = new SqlConnection(cConnection.connectionString);
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select * from tblUser Where colUserName ='" + paraUserName + "'";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;




            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;



            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblUser");

            tempUser.pUsername = oDataSet.Tables["tblUser"].Rows[0]["colUserName"].ToString();
            tempUser.pPassword = oDataSet.Tables["tblUser"].Rows[0]["colPassWord"].ToString();
            tempUser.pType = oDataSet.Tables["tblUser"].Rows[0]["colType"].ToString();
            tempUser.pDepartment = oDataSet.Tables["tblUser"].Rows[0]["colDepartment"].ToString();
        }

        public static DataSet fGridViewUser()
        {
            adocon = new SqlConnection();
            adocon.ConnectionString = cConnection.connectionString;
            adocon.Open();

            insertcmd = new SqlCommand();
            String vCommandText = "Select colUserName AS User_Name, colDepartment AS Department from tblUser";
            insertcmd.CommandText = vCommandText;
            insertcmd.Connection = adocon;

            SqlDataAdapter oAdapter = new SqlDataAdapter();
            oAdapter.SelectCommand = insertcmd;

            DataSet oDataSet = new DataSet();

            oAdapter.Fill(oDataSet, "tblUser");
            return oDataSet;


        }
    }
}