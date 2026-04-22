using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drs
{
	public partial class WebForm3 : System.Web.UI.Page
	{

		Regex = .*@.*\d.*[A - Z].*

		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

		public void login(){

		SqlCommand cmd = new SqlCommand("select count(*) from tbl_sender where name=@name and password=@password",con);
			cmd.Parameters.AddWithValue("@name",txtname.Text);
			cmd.Parameters.AddWithValue("@password", txtpwd.Text);
			con.Open();
			int i = Convert.ToInt32(cmd.ExecuteScalar());
			con.Close();
			Response.Write("Value = " + i);
			if (i == 1)
			{
				Session["user"] = txtname.Text;
				Response.Redirect("home.aspx");
			}
			else {
				Response.Write("No User Found");
			}

			

		}

		


		protected void Page_Load(object sender, EventArgs e)
		{

		

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Response.Write("Value = ");
			login();
		}
	}
}