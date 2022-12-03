using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Add the below
using System.Data;
using System.Data.SqlClient;

namespace ADO_27_11.Pages
{
    public static class Helper1
    {
        public const string DBname = "Database1.mdf";
        public const string tblName = "items";
        public const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\ADO_27_11\ADO_27_11\App_Data\" +
            DBname + "; Integrated Security = True";
        

        public static DataSet RetreiveDataSetTable(string SQLStr)
        {
            // Connection object to connect to the DB
            SqlConnection con = new SqlConnection(conString);

            // Build SQL queary 
            SqlCommand cmd = new SqlCommand(SQLStr, con);

            // Build the adapter
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            // Build the DataSet "המיכל" .. to store the data
            DataSet ds = new DataSet();

            // Get the data from the DataBase into the Dataset
            ad.Fill(ds, tblName);
            return ds;

        }

        public static string BuildHtmlTable(DataTable dt)
        {
            string str = "<table class='ProducTable' align = 'center'>";
            str += "<tr>";
            //
            str  += "<th align='center'> mark  </th>";
            //
            foreach (DataColumn column in dt.Columns)
            {

                str  += "<th align='center'>  " + column.ColumnName + "  </th>";
            }

            foreach (DataRow row in dt.Rows)
            {
                str += "<tr>";
                //
                str += "<td>" + CreateChkButton(row["Id"].ToString()) + "</td>";
                //
                foreach (DataColumn column in dt.Columns)
                {
                    str += "<td  align='left'>  " + row[column] + "  </td>";
                }
                str += "</tr>";
            }
            str += "</tr>";
            str += "</table>";

            return str;
        }
        public static string CreateChkButton(string id)
        {
            return $"<input type = 'checkbox' name='chk{id}' id='chk{id}' runat='setver' />";
        }

    }
}
