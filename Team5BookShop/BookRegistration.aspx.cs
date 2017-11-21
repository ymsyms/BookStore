using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BookRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BusinessLogic bl = new BusinessLogic();
        List<string> cat = bl.GetCategoryList();
        for(int i=0; i<cat.Count; i++)
        {
            ddlistCat.Items.Add(cat[i]);
        }
    }
}