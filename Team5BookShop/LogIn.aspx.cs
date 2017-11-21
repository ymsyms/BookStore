using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string userName = TextBox1.Text;
        string password = Password1.Value;
        bool isValid = userBusinessLogic.LoginVerification(userName, password);

        if(isValid)
        {
            User user = userBusinessLogic.GetUserByUserName(userName);
            Session["userId"] = user.UserID;
            Session["userType"] = user.UserType;

            Label3.Text = "Success User";
           
            if (Session["Url"] == null || Session["Url"].Equals("http://localhost:65213/ShoppingCartPage.aspx"))
            {
                Response.Redirect("~/OrderReceipt.aspx");
            }
            else
            {
                Response.Redirect("~/Main.aspx");
            }
        }
        else
        {
            Label3.Text = "Invalid User";
        }    
    }

}