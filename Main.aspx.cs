using System;
using System.Web.UI;

public partial class Main : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SessionID"] == null)
        {
            Response.Redirect("Default.aspx");
        }

    }

    protected void Logout_OnClick(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}