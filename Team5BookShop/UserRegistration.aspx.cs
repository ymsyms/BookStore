using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class UserRegisteration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed7_Click(object sender, EventArgs e)
    {
        Thread.Sleep(3000);
        Response.Redirect("~/Login.aspx");
    }
}