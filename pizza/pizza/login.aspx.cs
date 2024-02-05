using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class login : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["UNAME"] != null && Request.Cookies["UPWD"] != null)
            {
                email.Text = Request.Cookies["UNAME"].Value;
                password.Attributes["Value"] = Request.Cookies["UPWD"].Value;

            }
        }
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand cmd = new SqlCommand("select * from log_in where Email='" + email.Text.Trim() + "' AND Password='" + password.Text.Trim() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                
                    Response.Cookies["UNAME"].Value = email.Text;
                    Response.Cookies["UPWD"].Value = password.Text;

                    Response.Cookies["UNAME"].Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies["UPWD"].Expires = DateTime.Now.AddMinutes(1);


                

               
               

                while (dr.Read())
                {
                    Response.Write("<script>alert('Successful login');</script>");
                   
                   
                }
                Response.Redirect("index.aspx");

            }
            else
            {
                Response.Write("<script>alert('Invalid credentials');</script>");
            }

        }
        catch (Exception ex)
        {

        }
    }
}
