using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    BookshopEntities1 bookEntity;
    protected void Page_Load(object sender, EventArgs e)
    {
        bookEntity = new BookshopEntities1();
        BusinessLogic bl = new BusinessLogic();
        List<Book> lstBook;

        try
        {
            lstBook = bl.GetAllBooks();

            int j = 0;

            for (int i = 0; i < lstBook.Count; i++)
            {
                ImageButton img = new ImageButton();
                img.Width = 280;
                img.Height = 280;
                string imgName = lstBook[i].ISBN;
                img.ImageUrl = "images/" + imgName + ".jpg";
                PlaceHolder1.Controls.Add(img);


                img.PostBackUrl = "~/bookDetail.aspx?BookID=" + imgName;

                //Button btnCart = new Button();
                //btnCart.Text = "Add to Cart";
                //PlaceHolder1.Controls.Add(btnCart);

                j++;
                if (j == 3)
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


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["SearchItem"] = Master.FindControl("txtSearch").ToString();
        Response.Redirect("SearchResult.aspx");
    }
}