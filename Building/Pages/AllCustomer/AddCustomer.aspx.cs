using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllCustomer
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.FIO = TextBoxFIO.Text;
            Response.Redirect("~/Pages/AllCustomer/ListCustomer.aspx");
        }
    }
}