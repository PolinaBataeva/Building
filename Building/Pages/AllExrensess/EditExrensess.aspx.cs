using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllExrensess
{
    public partial class EditExrensess : System.Web.UI.Page
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
            Exrenses exrensess = DataAccessor.SelectExrenses(id);
            TextBoxWorkPerformel.Text = exrensess.WorkPerformel.ToString();
            TextBoxCostAmount.Text = exrensess.CostAmount.ToString();

        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Exrenses exrensess = new Exrenses();
            exrensess.IdExrenses = id;
            exrensess.WorkPerformel = TextBoxWorkPerformel.Text;
            exrensess.CostAmount = int.Parse(TextBoxCostAmount.Text);
            Response.Redirect("~/Pages/AllExrensess/ListExrensess.aspx");
        }
    }
}