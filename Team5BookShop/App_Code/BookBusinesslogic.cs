using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookBusinesslogic
/// </summary>
public class BookBusinesslogic
{
    public BookBusinesslogic()
    {

    }
    
    public Book GetBookDetails(int id)
    {
        using (BookshopEntities1 bookEntity = new BookshopEntities1())
        {
            Book book = (from bk in bookEntity.Books
                         where bk.BookID == id
                         select bk).First();
            return book;
        }

    }
}
