using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

public partial class SearchResult : System.Web.UI.Page
{
    BookshopEntities1 bookEntity;
    protected void Page_Load(object sender, EventArgs e)
    {
        string search;
        search= (string)(Session["SearchItem"]);

        bookEntity = new BookshopEntities1();
        BusinessLogic bl = new BusinessLogic();
        List<Book> lstBook;
        
        try
        {
            lstBook = bl.GetBooksByTitle(search);

            int j = 0;

            for (int i = 0; i < lstBook.Count; i++)
            {
                Image img = new Image();
                img.Width = 280;
                img.Height = 280;
                string imgName = lstBook[i].ISBN;
                img.ImageUrl = "images/" + imgName + ".jpg";
                PlaceHolder1.Controls.Add(img);

                //Button btnCart = new Button();
                //btnCart.Text = "Add to Cart";
                //PlaceHolder1.Controls.Add(btnCart);

                j++;
                if (j == 4)
                {
                    PlaceHolder1.Controls.Add(new LiteralControl("<br/><br/>"));
                    j = 0;
                }
            }
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(Page.GetType(),
     "MessageBox",
     "<script language='javascript'>alert('" + ex.Message + "');</script>");
        }

    }
}