using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drs
{
	public partial class WebForm4 : System.Web.UI.Page
	{

		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


		public void grid() {

			SqlCommand cmd = new SqlCommand("select * from tbl_sender",con);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			da.Fill(dt);

			gv1.DataSource = dt;
			gv1.DataBind();
			dd1.DataSource = dt;
			dd1.DataTextField = "name";
			dd1.DataValueField = "name";
			dd1.DataBind();

		}
		protected void dd(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("select * from tbl_sender", con);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			da.Fill(dt);

			
			dd2.DataSource = dt;
			dd2.DataTextField = "sender_id";
			dd2.DataValueField = "sender_id";
			dd2.DataBind();
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			Response.Write(Session["user"]);

			if (!IsPostBack) {
				grid();
			}
		}
	}
}