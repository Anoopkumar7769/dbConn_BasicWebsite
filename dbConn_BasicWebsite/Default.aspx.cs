using System;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\237598\Desktop\ASP.NET\dbConn_BasicWebsite\dbConn_BasicWebsite\App_Data\Databasedb.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            disp_data();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into studentdb values('" + usn.Text + "','" + name.Text + "','" + city.Text + "','" + Phone_no.Text + "')";
        cmd.ExecuteNonQuery();
        usn.Text = "";
        name.Text = "";
        city.Text = "";
        Phone_no.Text = "";
        con.Close();
        disp_data();

    }

    public void disp_data()
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from studentdb";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from studentdb where usn='" + usn.Text + "' ";
        cmd.ExecuteNonQuery();

        usn.Text = "";

        con.Close();
        disp_data();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
      
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update studentdb set name= '" + name.Text + "',city='" + city.Text + "', Phone_no='" + Phone_no.Text + "' where usn='" + usn1.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
        usn.Text = "";
        name.Text = "";
        city.Text = "";
        Phone_no.Text = "";
        disp_data();
       
       
    }

    protected void usn_TextChanged(object sender, EventArgs e)
    {
        if(usn.Text.Length > 0)
        {
            usn1.Enabled = false;
        }
        else
        {
            usn1.Enabled = true;
        }
    }
    protected void usn1_TextChanged(object sender, EventArgs e)
    {
        if (usn1.Text.Length > 0)
        {
            usn.Enabled = false;
        }
        else
        {
            usn.Enabled = true;
        }
    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        disp_data();

    }
}