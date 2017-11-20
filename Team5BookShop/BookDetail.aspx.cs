using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    BookshopEntities1 bk = new BookshopEntities1();
    int bookId;
    Book bookItem;
    CartItem cartItem;

    protected void Page_Load(object sender, EventArgs e)
    {
        string val = Request.QueryString["BookID"];
        if (val != null)
        {
            bookId = Convert.ToInt32(val);
            bookItem = new BookBusinesslogic().GetBookDetails(bookId);
            Category cat = new BookBusinesslogic().GetCategory(bookItem.CategoryID);
            Image Image2 = new Image();
            Image2.Width = 280;
            Image2.Height = 280;
            Image2.ImageUrl = "images/" + bookItem.ISBN + ".jpg";
            lblTitle.Text = bookItem.Title;
            lblCat.Text = Convert.ToString(cat.CategoryName);
            lblISBN.Text = bookItem.ISBN;
            lblAuthor.Text = bookItem.Author;
            lblPrice.Text = Convert.ToString(bookItem.Price);
        }
    }

    protected void BtnAddToCart_Click(object sender, EventArgs e)
    {
<<<<<<< HEAD
        int quantity = Convert.ToInt16(qty);
        ShoppingCart sc = new ShoppingCart();
        sc.Add(bookItem, quantity);
        Response.Request
=======
        Session["Quantity"] = qty.Value.ToString();
        Response.Redirect("ShoppingCart.aspx");
>>>>>>> 05e0276902731be906295eb7c973657093ebbb8d
    }


}

 