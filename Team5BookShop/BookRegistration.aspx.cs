using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookRegistration : System.Web.UI.Page
{
    BusinessLogic bl;
    BookBusinesslogic bbl;
    protected void Page_Load(object sender, EventArgs e)
    {
        bl = new BusinessLogic();
        List<string> cat = bl.GetCategoryList();
        for(int i=0; i<cat.Count; i++)
        {
            ddlistCat.Items.Add(cat[i]);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //if(decimal.TryParse(txtPrice.Text))
        bbl = new BookBusinesslogic();

        string title = txtTitle.Text;
        string cat = ddlistCat.SelectedItem.ToString();
        string isbn = txtISBN.Text;
        string author = txtAuthor.Text;
        int stock = Convert.ToInt32(bookStock.Value);
        decimal price = Convert.ToDecimal(txtPrice.Text);

        if (bbl.AddBook(title, cat, isbn, author, stock, price))
            Label1.Text = "Successful";
        else
            Label1.Text = "Error";

        

    }
}