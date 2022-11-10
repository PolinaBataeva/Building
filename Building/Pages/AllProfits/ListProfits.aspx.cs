using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllProfits
{
    public partial class ListProfits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            GridViewProfits.AutoGenerateColumns = false;
            GridViewProfits.DataSource = DataAccessor.SelectProfit();
            GridViewProfits.DataBind();
        }

        protected void GridViewProfits_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewProfits.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteProfit(id);
            BindGrid();
        }

        protected void GridViewProfits_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверенны что хотите удалить запись?');";
            }
        }
    }
}