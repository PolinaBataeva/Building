using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllWorkPerfomels
{
    public partial class EditWorkPerfomels : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "Id не определено!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }
            LabelMessage.Text = "";
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {

                BindControls();
            }
        }
        private void BindControls()
        {
            WorkPerformel staff = DataAccessor.SelectWorkPerformel(id);
            TextBoxTypeOfWork.Text = staff.TypeOfWork.ToString();
            TextBoxDurability.Text = staff.Durability.ToString();

        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            WorkPerformel staff = new WorkPerformel();
            staff.IdWork = id;
            staff.TypeOfWork = TextBoxTypeOfWork.Text;
            staff.Durability = int.Parse(TextBoxDurability.Text);
            Response.Redirect("~/Pages/AllWorkPerfomels/ListWorkPerfomels.aspx");
        }
    }
}