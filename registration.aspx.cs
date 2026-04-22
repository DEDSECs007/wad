using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Policy;
using System.Security.Cryptography.X509Certificates;

namespace drs
{
	public partial class WebForm1 : System.Web.UI.Page
	{

		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


		public void insert() {

			SqlCommand cmd = new SqlCommand("insert into tbl_sender(name,password) values(@name,@password) ",con);
			cmd.Parameters.AddWithValue("@name",txtid.Text);
			cmd.Parameters.AddWithValue("@password", txtpwd.Text);
			cmd.Parameters.AddWithValue("@city", ddlcity.SelectedValue);
			cmd.Parameters.AddWithValue("@status", chkactive.Checked);
			cmd.Parameters.AddWithValue("@status", chkactive.Checked ? 1 : 0);
			string gender = "";

			if (rdmale.Checked)
			{
				gender = "Male";
			}
			else if (rdfemale.Checked)
			{
				gender = "Female";
			}

			cmd.Parameters.AddWithValue("@gender", gender);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

		}

		protected void Page_Load(object sender, EventArgs e)
		{
			

		}

		protected void txtid_TextChanged(object sender, EventArgs e)
		{
			insert();
			Response.Redirect("Login.aspx");
		}
	}
}