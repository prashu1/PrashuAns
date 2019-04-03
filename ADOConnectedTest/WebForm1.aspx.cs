using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOConnectedTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection getconnection()
        {
            return new SqlConnection(@"data source=LAPTOP-UOE8L24G\GRIDINFOCOM;initial catalog=ADOTest;integrated security=true");
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            using (con = getconnection())
            {
                using (cmd = new SqlCommand("InsertTest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@AddressId", AddressID.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FName.Text);
                    cmd.Parameters.AddWithValue("@LastName", LName.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    //cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("Record Inserted");
                }
            }

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            using  (con = getconnection())
            {
                using (cmd = new SqlCommand("UpdateTest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AddressId", AddressID.Text);
                    cmd.Parameters.AddWithValue("@LastName", LName.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FName.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("record updated");
                }
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            using (con = getconnection())
            {


                using (cmd = new SqlCommand("DeleteTest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AddressId", AddressID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("record Deleted");
                }
            }
        }
        protected void FName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}