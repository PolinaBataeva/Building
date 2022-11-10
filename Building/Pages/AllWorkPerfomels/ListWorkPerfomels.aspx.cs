using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllWorkPerfomels
{
    public partial class ListWorkPerfomels : System.Web.UI.Page
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
            GridViewWorkPerfomels.AutoGenerateColumns = false;
            GridViewWorkPerfomels.DataSource = DataAccessor.SelectWorkPerformel();
            GridViewWorkPerfomels.DataBind();
        }
        protected void GridViewWorkPerfomels_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewWorkPerfomels.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteWorkPerformel(id);
            BindGrid();
        }

        protected void GridViewWorkPerfomels_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверенны что хотите удалить запись?');";
            }
        }
    }
}