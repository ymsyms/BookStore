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
            Panel1.Controls.Add(emptyCartLabel);
            GridView1.Visible = false;
            //ShoppingCartph.Controls.Add(emptyCartLabel);
        }
        else
        {
            GridView1.DataSource = userCart.Cart;
            GridView1.DataBind();
        }
    

    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
    //int a = 0;
    //    decimal sumPirceTxt = 0;
    //    for (int rowindex = 0; rowindex < this.GridView1.Rows.Count; rowindex++)
    //    {
    //        TextBox quantityTxt = ((TextBox)GridView1.Rows[rowindex].Cells[0].FindControl("quantityTxt"));

    //        Label Price = ((Label)GridView1.Rows[rowindex].Cells[0].FindControl("Price"));
    //        Decimal PirceTxt = Convert.ToDecimal(Price.Text);
    //        int quantity = Convert.ToInt32(quantityTxt.Text);
    //        a += quantity;
    //        decimal allPirce = PirceTxt * quantity;
    //        sumPirceTxt += allPirce;


    //    }





        //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        //{

        //    int a = 0;
        //    decimal sumPirceTxt = 0;
        //    for (int rowindex = 0; rowindex < this.GridView1.Rows.Count; rowindex++)
        //    {
        //        TextBox quantityTxt = ((TextBox)GridView1.Rows[rowindex].Cells[0].FindControl("quantityTxt"));

        //        Label Price = ((Label)GridView1.Rows[rowindex].Cells[0].FindControl("Price"));
        //        Decimal PirceTxt = Convert.ToDecimal(Price.Text);
        //        int quantity = Convert.ToInt32(quantityTxt.Text);
        //        a += quantity;
        //        decimal allPirce = PirceTxt * quantity;
        //        sumPirceTxt += allPirce;
        //        //删除Convert.ToInt32(this.GridView1.DataKeys[rowindex].Value)
        //    }

        //if (e.Row.RowType == DataControlRowType.DataRow || e.Row.RowType == DataControlRowType.Separator)
        //{
        //    //int quantity = int.Parse(e.Row.Cells[2].Text);
        //    Label allPirceTxt = ((Label)e.Row.FindControl("allPirceTxt"));
        //    Label Price = ((Label)e.Row.FindControl("Price"));
        //    Decimal PirceTxt = Convert.ToDecimal(Price.Text);
        //    TextBox quantity = ((TextBox)e.Row.FindControl("quantityTxt"));
        //    int num = int.Parse(quantity.Text);
        //    Price.Text = PirceTxt.ToString().Substring(0, 5);
        //    allPirceTxt.Text = string.Format("{0:c}", PirceTxt * num);

        //  }
        //numTxt.Text = GridView1.Rows.Count.ToString();
        //allNumTxt.Text = a.ToString();
        //CartPriceTxt.Text = string.Format("{0:c}", sumPirceTxt);
        //Session["orderPrice"] = CartPriceTxt.Text;
        // }

        //protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        //{
        //    GridView1.DataBind();

        //}


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

