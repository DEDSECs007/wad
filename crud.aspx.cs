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

	public partial class WebForm5 : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

		public void update() {
			SqlCommand cmd = new SqlCommand("update tbl_sender set id=@id2, name=@name where id=@id",con);
			cmd.Parameters.AddWithValue("@id",id.Text);
			cmd.Parameters.AddWithValue("@id2",id2.Text);
			cmd.Parameters.AddWithValue("@name",name.Text);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();

			

		}

		public void gv() {
			SqlCommand cmd = new SqlCommand("Select * from tbl_sender",con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			gv1.DataSource = dt;
			gv1.DataBind();


		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) {
				gv();
				gv();
			}

		}

		protected void btnupdate_Click(object sender, EventArgs e)
		{

			update();
			gv();

		}
		protected void Button2_Click(object sender, EventArgs e)
		{

		}
		protected void Button3_Click(object sender, EventArgs e)
		{

		}

		protected void name_TextChanged(object sender, EventArgs e)
		{

		}
	}
}