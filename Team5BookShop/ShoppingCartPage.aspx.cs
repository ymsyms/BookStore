using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCartPage : System.Web.UI.Page
{
    ShoppingCart userCart;
    protected void Page_Load(object sender, EventArgs e)
    {
        userCart = (ShoppingCart)Session["ShoppingCartObj"];
        if (userCart.Cart.Count == 0)
        {
            Label emptyCartLabel = new Label();
            emptyCartLabel.Text = "Your Shopping Cart is Empty";
            Panel1.Controls.Add(emptyCartLabel);
            GridView1.Visible = false;
        }
        else
        {
            GridView1.DataSource = userCart.Cart;
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteCartItem")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            userCart.Remove(index);
            GridView1.DataBind();
            Session["ShoppingCartObj"] = userCart;
            Response.Redirect("~/ShoppingCartPage.aspx");
        }
    }
}

