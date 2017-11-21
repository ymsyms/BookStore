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
        //Just to test
        Book boo = new Book();
        boo.Stock = 100;
        boo.Title = "kikiki";
        userCart = new ShoppingCart();
        userCart.Add(boo, 3);
        userCart.Add(boo, 3);
        userCart.Add(boo, 3);
        //
        //userCart = (ShoppingCart)Session["ShoppingCartObj"];
        if (userCart.Cart.Count == 0)
        {
            Label emptyCartLabel = new Label();
            emptyCartLabel.Text = "Your Shopping Cart is Empty";
            Panel1.Controls.Add(emptyCartLabel);
            GridView1.Visible = false;
            //ShoppingCartph.Controls.Add(emptyCartLabel);
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

            //Remove cart Item
            //if (index > 0 && index < userCart.Cart.Count)
            //{
            //    if (userCart.Cart[index] != null)
            //    {
            //        userCart.Cart.Remove(userCart.Cart[index]);
            //    }
            //}
            //GridView1.DataBind();
            userCart.Remove(index);
            GridView1.DataBind();
        }
    }
}

