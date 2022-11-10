using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllWorkPerfomels
{
    public partial class AddWorkPerfomels : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            WorkPerformel staff = new WorkPerformel();
            staff.TypeOfWork = TextBoxTypeOfWork.Text;
            staff.Durability = int.Parse(TextBoxDurability.Text);
            Response.Redirect("~/Pages/AllWorkPerfomels/ListWorkPerfomels.aspx");
        }
    }
}