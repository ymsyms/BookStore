using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookBusinesslogic
/// </summary>
public class BookBusinesslogic
{
    Book book;
    int catId;
    public BookBusinesslogic()
    {

    }
    
    public Book GetBookDetails(int id)
    {
        using (BookshopEntities bookEntity = new BookshopEntities())
        {
             book = (from bk in bookEntity.Books
                         where bk.BookID == id
                         select bk).First();
            catId = book.CategoryID;
            return book;
        }

    }
    public Category GetCategory(int catId)
    {
        using (BookshopEntities category = new BookshopEntities())
        {
            Category catgry = (from ct in category.Categories
                               where ct.CategoryID == catId
                               select ct).First();
            return catgry;
        }

    }

    
}
