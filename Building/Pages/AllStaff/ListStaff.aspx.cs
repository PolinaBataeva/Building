using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllStaff
{
    public partial class ListStaff : System.Web.UI.Page
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
            GridViewStaffs.AutoGenerateColumns = false;
            GridViewStaffs.DataSource = DataAccessor.SelectStaff();
            GridViewStaffs.DataBind();
        }

        protected void GridViewStaffs_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewStaffs.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteStaff(id);
            BindGrid();
        }

        protected void GridViewStaffs_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверенны что хотите удалить запись?');";
            }
        }
    }
}