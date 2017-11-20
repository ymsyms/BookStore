using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCartPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Just to test
        Book boo = new Book();
        boo.Stock = 100;
        boo.Title = "kikiki";
        ShoppingCart userCart = new ShoppingCart();
        userCart.Add(boo, 3);
        userCart.Add(boo, 4);
        userCart.Add(boo, 5);
        //
        //ShoppingCart userCart = (ShoppingCart)Session["ShoppingCartObj"];
        if (userCart.Cart.Count == 0)
        {
            Label emptyCartLabel = new Label();
            emptyCartLabel.Text = "Your Shopping Cart is Empty";
            ShoppingCartph.Controls.Add(emptyCartLabel);
        }
        else
        {
            GridView1.DataSource = userCart.Cart;
            GridView1.DataBind();
            ShoppingCartph.Controls.Add(GridView1);
        }
    }
}

