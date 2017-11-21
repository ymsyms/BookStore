using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["SearchItem"] = txtSearch.Value.ToString();
        Response.Redirect("~/SearchResult.aspx");        
    }

    protected void btnSignIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void btnSignOut_Click(object sender, EventArgs e)
    {
        Session["userId"] = null;
        Response.Redirect("~/Main.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userId"] == null)
        {
            btnSignOut.Visible = false;
        }
        else
        {
            btnSignIn.Visible = false;
        }

    }
}
