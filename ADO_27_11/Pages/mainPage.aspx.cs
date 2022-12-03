using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Add the below
using System.Data;
using System.Data.SqlClient;

namespace ADO_27_11.Pages
{
    public partial class mainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //string SQLstr = "SELECT * FROM items";
                string SQLstr = "select * from items";
                //DataSet ds = RetrieveProductTable(SQLstr);
                DataSet ds = Helper1.RetreiveDataSetTable(SQLstr);
                //DataSet ds = 
                DataTable dt = ds.Tables["items"];
                //string table = BuildProductTable(dt);
                string table = Helper1.BuildHtmlTable(dt);
                tableDiv.InnerHtml = table;
            }
            
        }
        public void Delete(Object sender, EventArgs e)
        {
            //string SQLstr = "SELECT * FROM items";
            string SQLstr = "select * from items";

            string connectionString = Helper1.conString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(SQLstr,con);
            
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            // Build DataSet to store the data
            DataSet ds = new DataSet();

            ad.Fill(ds, "list");
            for (int i = 1; i < Request.Form.Count; i++)
            {
                if (Request.Form.AllKeys[i].Contains("chk"))
                {
                    int itemId = int.Parse(Request.Form.AllKeys[i].Remove(0, 3));
                    DataRow[] dr = ds.Tables["list"].Select($"Id={itemId}");
                    dr[0].Delete();
                }

            }
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            ad.UpdateCommand = builder.GetUpdateCommand();
            ad.Update(ds, "list");

            string tbl = Helper1.BuildHtmlTable(ds.Tables["list"]);
            tableDiv.InnerHtml=tbl;
        }
    }
}