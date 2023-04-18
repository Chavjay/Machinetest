using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			loadrecord();
		}
	}
	SqlConnection con = new SqlConnection("Data Source=LAPTOP-OQPKJRKS\\SQLEXPRESS;Initial Catalog=newcore;Integrated Security=True");

	protected void Button1_Click(object sender, EventArgs e)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("Insert into Category values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "')", con);
		cmd.ExecuteNonQuery();
		con.Close();
		ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
		loadrecord();

	}
	void loadrecord()
	{
		SqlCommand cmd = new SqlCommand("select * from Category", con);
		SqlDataAdapter adapter = new SqlDataAdapter(cmd);
		DataTable dt = new DataTable();
		adapter.Fill(dt);
		GridView1.DataSource = dt;
		GridView1.DataBind();
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("update Category set CategoryName='" + TextBox2.Text + "' where CategoryId='" + int.Parse(TextBox1.Text) + "'", con);
		cmd.ExecuteNonQuery();
		con.Close();
		ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
		loadrecord();
	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("delete Category  where CategoryId='" + int.Parse(TextBox1.Text) + "'", con);
		cmd.ExecuteNonQuery();
		con.Close();
		ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
		loadrecord();
	}


	protected void Button5_Click(object sender, EventArgs e)
	{
		SqlCommand cmd = new SqlCommand("select * from Category where CategoryId='" + int.Parse(TextBox1.Text) + "'", con);
		SqlDataAdapter adapter = new SqlDataAdapter(cmd);
		DataTable dt = new DataTable();
		adapter.Fill(dt);
		GridView1.DataSource = dt;
		GridView1.DataBind();
	}

	protected void Button6_Click(object sender, EventArgs e)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("select * from Category where CategoryId='" + int.Parse(TextBox1.Text) + "'", con);
		SqlDataReader reader = cmd.ExecuteReader();
		while(reader.Read())
		{
			TextBox2.Text=reader.GetValue(1).ToString();
		}

	}
}