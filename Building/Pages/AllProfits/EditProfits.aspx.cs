using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllProfits
{
    public partial class EditProfits : System.Web.UI.Page
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
            Profit profits = DataAccessor.SelectProfit(id);
            TextBoxDate.Text = profits.Date.ToString();
            TextBoxProfits.Text = profits.Profits.ToString();

        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Profit profits = new Profit();
            profits.IdProfit = id;
            profits.Date = int.Parse(TextBoxDate.Text);
            profits.Profits = int.Parse(TextBoxProfits.Text);
            Response.Redirect("~/Pages/AllProfits/ListProfits.aspx");
        }
    }
}