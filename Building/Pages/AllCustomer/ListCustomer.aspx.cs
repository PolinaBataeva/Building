using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllCustomer
{
    public partial class ListCustomer : System.Web.UI.Page
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
                GridViewCustomer.AutoGenerateColumns = false;
                GridViewCustomer.DataSource = DataAccessor.SelectCustomers();
                GridViewCustomer.DataBind();
            }

            protected void GridViewCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
                int id = int.Parse(GridViewCustomer.Rows[e.RowIndex].Cells[0].Text);
                DataAccessor.DeleteCustomers(id);
                BindGrid();
            }

            protected void GridViewCustomer_RowDataBound(object sender, GridViewRowEventArgs e)
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверенны что хотите удалить запись?');";
                }
            }
    }
}