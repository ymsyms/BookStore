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
}
