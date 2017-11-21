using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderReceipt : System.Web.UI.Page
{
    ShoppingCart userCart;
    string mailingAddress;
    protected void Page_Load(object sender, EventArgs e)
    {
        userCart = (ShoppingCart)Session["ShoppingCartObj"];
        GridView1.DataSource = userCart.Cart;
        GridView1.DataBind();
    }

    protected void PurchaseBtn_Click(object sender, EventArgs e)
    {
        DateTime current = new DateTime();
        string userID = (string) Session["UserID"];
        mailingAddress= Addresstb.Text+","+StateCitytb.Text+","+Countrytb.Text+","+ZipCodetb.Text;
        BusinessLogic buzy = new BusinessLogic();
        if (buzy.Checkout(userID, mailingAddress, current.Date, userCart.TotalPrice(), userCart))
        {
            Response.Redirect("~/Main.Aspx");
        }
        else
        {
            failurelb.Text = "Failed to log purchase. Please try again later";
        }
    }
}