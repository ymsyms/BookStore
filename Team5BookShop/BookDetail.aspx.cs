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
        //shoppingcart.cs
        //ShoppingCart sc = new ShoppingCart();
        //sc.Add(book, quantity);

        //add method if ok
        //Response.Redirect("ShoppingCart.aspx");
    }
}

 