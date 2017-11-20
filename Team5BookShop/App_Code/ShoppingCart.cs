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
    public void Remove(int index)
    {
        cart.Remove(cart[index]);
    }
    public List<CartItem> Cart
    {
        get
        {
            return cart;
        }
    }

    public decimal TotalPrice()
    {
        decimal totalPrice = 0;
        foreach (CartItem cartItem in cart)
        {
            totalPrice += cartItem.SubTotal;
        }
        return totalPrice;
    }
}