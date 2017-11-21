using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

/// <summary>
/// Summary description for BusinessLogic
/// </summary>
public class BusinessLogic
{
    //01 homepage methods
    public List<Book> GetAllBooks()
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.ToList<Book>();
        }
    }

    public List<Book> GetBooksByTitle(string title)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.Where(book => book.Title.Contains(title)).ToList<Book>();
        }
    }

    public List<Book> GetBooksByCategoryID(int categoryID)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            return context.Books.Where(book => book.CategoryID == categoryID).ToList<Book>();
        }
    }

    //02 login page methods (by inetmgr)

    //03 registration page methods (by inetmgr)

    //04 shopping cart page methods



    //public void Checkout(string userID, string mailingAddress, DateTime orderDate, decimal totalPrice, ShoppingCart shoppoingCart)
    //{
    //    using (BookshopEntities context = new BookshopEntities())
    //    {
    //        //Create Order
    //        Order order = new Order();
    //        order.UserID = userID;
    //        order.MailingAddress = mailingAddress;
    //        order.OrderDate = orderDate;
    //        order.TotalPrice = totalPrice;
    //        context.Orders.Add(order);
    //        context.SaveChanges();

    //        //Create OrderDetails from CartItems
    //        foreach (CartItem item in shoppingCart)
    //        {
    //            OrderDetail orderDetail = new OrderDetail();
    //            orderDetail.OrderID = context.Orders.Max(x => x.OrderID);
    //            orderDetail.BookID = item.BookID;
    //            orderDetail.Quantity = item.Quantity;
    //            orderDetail.UnitPrice = item.UnitPrice;
    //            orderDetail.SubTotalPrice = item.SubTotal;
    //            context.OrderDetails.Add(orderDetail);
    //        }
    //        context.SaveChanges();

    //        //Clear ShoppingCart
    //        shoppingCart.Clear();
    //    }


    //}

    public void Checkout(string userID, string mailingAddress, DateTime orderDate, decimal totalPrice, ShoppingCart shoppingCart)
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            //Create Order
            Order order = new Order();
            int userIDHolder;
            bool validUserID = Int32.TryParse(userID, out userIDHolder);

            order.MailingAddress = mailingAddress;
            order.OrderDate = orderDate;
            order.TotalPrice = Convert.ToDouble(totalPrice);

            if (validUserID)
            {
                order.UserID = userIDHolder;
                context.Orders.Add(order);
                context.SaveChanges();

                //Create OrderDetails from CartItems
                foreach (CartItem item in shoppingCart.Cart)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderID = context.Orders.Max(x => x.OrderID);
                    orderDetail.BookID = Convert.ToInt16(item.BookID);
                    orderDetail.Quantity = Convert.ToInt16(item.Quantity);
                    orderDetail.UnitPrice = Convert.ToDouble(item.UnitPrice);
                    orderDetail.SubtotalPrice = Convert.ToDouble(item.SubTotal);
                    context.OrderDetails.Add(orderDetail);
                }
                context.SaveChanges();

                //Clear ShoppingCart
                shoppingCart.Clear();
            }
        }
    }
    public List<string> GetCategoryList()
    {
        using (BookshopEntities context = new BookshopEntities())
        {
            List<string> catList = context.Categories.Select(x => x.CategoryName).ToList();
            return catList;
        }
    }

    public void imageAssign(List<Book> lstBook, PlaceHolder ph)
    {
        int j = 0;

        for (int i = 0; i < lstBook.Count; i++)
        {
            ImageButton img = new ImageButton();
            img.Width = 280;
            img.Height = 280;
            string imgName = lstBook[i].ISBN;
            img.ImageUrl = "images/" + imgName + ".jpg";

            ph.Controls.Add(img);

            img.PostBackUrl = "~/bookDetail.aspx?BookID=" + imgName;

            //Button btnCart = new Button();
            //btnCart.Text = "Add to Cart";
            //PlaceHolder1.Controls.Add(btnCart);

            j++;
            if (j == 3)
            {
                ph.Controls.Add(new LiteralControl("<br/><br/>"));
                j = 0;
            }
        }
    }
}