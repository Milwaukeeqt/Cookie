using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private const string Uname = "lol";
    private const string Pword = "lol";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        if (Request.Cookies["userinfo"] != null)
        {
            var rem = Request.Cookies["userinfo"]["rememberMe"];
            if (rem == "true")
            {
                Username.Text = Request.Cookies["userinfo"]["username"];
                RememberMe.Checked = true;
            }
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        if (Username.Text == Uname && Password.Text == Pword)
        {
            Session["SessionID"] = Uname;
            if (RememberMe.Checked)
            {
                if (Response.Cookies["userinfo"] != null)
                {
                    Response.Cookies["userinfo"]["username"] = Uname;
                    Response.Cookies["userinfo"]["password"] = Pword;
                    Response.Cookies["userinfo"]["rememberMe"] = "true";
                    Response.Cookies["userinfo"].Expires = DateTime.Now.AddDays(1);
                }
            }
            else
            {
                Response.Cookies["userinfo"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Main.aspx");
        }
        else
        {
            Response.Write("<script>alert('login not succesful')</script>");
        }
    }
}