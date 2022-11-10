using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllExrensess
{
    public partial class ListExrensess : System.Web.UI.Page
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
            GridViewExrensess.AutoGenerateColumns = false;
            GridViewExrensess.DataSource = DataAccessor.SelectExrenses();
            GridViewExrensess.DataBind();
        }

        protected void GridViewExrensess_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewExrensess.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteExrenses(id);
            BindGrid();
        }

        protected void GridViewExrensess_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверенны что хотите удалить запись?');";
            }
        }
    }
}