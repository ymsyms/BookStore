using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchCategoryResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int key = Convert.ToInt32(Request.QueryString[0].ToString());
        BusinessLogic b1 = new BusinessLogic();
        List<Book> bookList = new List<Book>();

        try
        {
            bookList = b1.GetBooksByCategoryID(key);

            int j = 0;

            for (int i = 0; i < bookList.Count; i++)
            {
                Image img = new Image();
                img.Width = 280;
                img.Height = 280;
                string imgName = bookList[i].ISBN;
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