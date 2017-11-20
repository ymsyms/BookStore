using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessLogic
/// </summary>
public class BusinessLogic
{
    //01 homepage methods
    public static List<Book> GetAllBooks()
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.ToList<Book>();
        }
    }

    public static List<Book> GetBooksByTitle(string title)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.Where(book => book.Title.Contains(title)).ToList<Book>();
        }
    }

    public static List<Book> GetBooksByCategoryID(int categoryID)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.Where(book => book.CategoryID == categoryID).ToList<Book>();
        }
    }

    //02 login page methods (by inetmgr)

    //03 registration page methods (by inetmgr)

    //04 shopping cart page methods
    public static List<CartItem> GetShoppingCart()
    {
        return shoppingCart;
    }

    //EditCartItem (in CodeBehind)

    public static decimal GetShoppingCartTotalPrice()
    {
        return shoppingCart.TotalPrice();
    }

    public static void Checkout(string userID, string mailingAddress, DateTime orderDate, decimal totalPrice)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            //Create Order
            Order order = new Order();
            order.UserID = userID;
            order.MailingAddress = mailingAddress;
            order.OrderDate = orderDate;
            order.TotalPrice = totalPrice;
            context.Orders.Add(order);
            context.SaveChanges();

            //Create OrderDetails from CartItems
            foreach (CartItem item in shoppingCart)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderID = context.Orders.Max(x => x.OrderID);
                orderDetail.BookID = item.BookID;
                orderDetail.Quantity = item.Quantity;
                orderDetail.UnitPrice = item.UnitPrice;
                orderDetail.SubTotalPrice = item.SubTotal;
                context.OrderDetails.Add(orderDetail);
            }
            context.SaveChanges();

            //Clear ShoppingCart
            shoppingCart.Clear();
        }


    }
}