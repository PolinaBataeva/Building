using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllProfits
{
    public partial class AddProfits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) ;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Profit profits = new Profit();
            profits.Date = int.Parse(TextBoxDate.Text);
            profits.Profits = int.Parse(TextBoxProfits.Text);
            Response.Redirect("~/Pages/AllProfits/ListProfits.aspx");
        }
    }
}