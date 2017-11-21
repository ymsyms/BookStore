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
    BookshopEntities1 be;
    Category category;


    public BookBusinesslogic()
    {

    }
    
    public Book GetBookDetails(string id)
    {
        using (BookshopEntities bookEntity = new BookshopEntities())
        {
             book = (from bk in bookEntity.Books
                         where bk.ISBN == id
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

    public bool AddBook(string title, string cat, string isbn, string author, int stock, decimal price)
    {
        be = new BookshopEntities1();
        book = new Book();
        category = new Category();

        try
        {
            book.Title = title;            
            book.ISBN = isbn;
            book.Author = author;
            book.Stock = stock;
            book.Price = price;            

            var c = be.Categories.Where(x => x.CategoryName == cat).Select(x => x.CategoryID).First();            
            book.CategoryID = c;

            be.Books.Add(book);
            return true;
        }
        catch(Exception ex)
        {            
            return false;
        } 
    }
}
