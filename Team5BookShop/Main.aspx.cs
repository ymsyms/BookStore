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

        List<Book> lstBook = bl.GetAllBooks();        

        for(int i=0; i<lstBook.Count; i++)
        {
            Image img = new Image();
            string imgName = lstBook[i].ISBN;
            img.ImageUrl = "images/" + imgName  +".jpg";
        }
    }
}