using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{

    List<CartItem> cart;


    public void Add(Book book, int quantity)
    {
        if (book.Stock >= quantity)
        {
            CartItem newItem = new CartItem(book, quantity);
            cart.Add(newItem);
        }
    }

    public void Clear()
    {
        cart.Clear();
    }
    public List<CartItem> Cart
    {
        get
        {
            return cart;
        }
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        foreach (CartItem cartItem in cart)
        {
            totalPrice += cartItem.SubTotal;
        }
        return totalPrice;
    }
}