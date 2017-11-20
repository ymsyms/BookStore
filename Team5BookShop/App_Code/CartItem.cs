using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartItem
/// </summary>
public class CartItem
{

    string title;
    int quantity;
    decimal unitPrice;
    int bookID;

    public CartItem(Book book, int quantity)
    {
        this.title = book.Title;
        this.quantity = quantity;
        this.unitPrice = book.Price;
        this.bookID = book.BookID;
    }

    public string Title
    {
        get
        {
            return title;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
    }

    public double UnitPrice
    {
        get
        {
            return unitPrice;
        }
    }

    public int BookID
    {
        get
        {
            return bookID;
        }
    }

    public double SubTotal
    {
        get
        {
            return unitPrice * quantity;
        }
    }
}