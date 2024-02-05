using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button2_Click(object sender, EventArgs e)
    {
       
    }


    protected void Button2_Click1(object sender, EventArgs e)
    {
        if (checkMemberExists())
        {

            Response.Write("<script>alert('Member Already Exist with this Member ID, try other ID');</script>");
        }
        else
        {
            signUpNewMember();
        }
    }

    // user defined method
    bool checkMemberExists()
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * from log_in where Email='" + TextBox1.Text.Trim() + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
            return false;
        }
    }
    void signUpNewMember()
    {
        //Response.Write("<script>alert('Testing');</script>");
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO log_in(Name,Password,Email,Phone) values(@Name,@Password,@Email,@Phone)", con);
            cmd.Parameters.AddWithValue("@Name", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", TextBox4.Text.Trim());

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login');</script>");
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }
    }
}
