using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllExrensess
{
    public partial class AddExrensess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Exrenses exrensess = new Exrenses();
            exrensess.WorkPerformel = TextBoxWorkPerformel.Text;
            exrensess.CostAmount = int.Parse(TextBoxCostAmount.Text);
            Response.Redirect("~/Pages/AllExrensess/ListExrensess.aspx");
        }
    }
}