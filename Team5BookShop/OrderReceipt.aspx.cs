using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderReceipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShoppingCart userCart = (ShoppingCart)Session["ShoppingCartObj"];
        ShoppingCartlv.DataSource = userCart;
        ShoppingCartlv.DataBind();
    }
}