using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllCustomer
{
    public partial class EditCustomer : System.Web.UI.Page
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
            Customers customer = DataAccessor.SelectCustomers(id);
            TextBoxFIO.Text = customer.FIO.ToString();

        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.IdCustomers = id;
            customer.FIO = TextBoxFIO.Text;
            Response.Redirect("~/Pages/AllCustomer/ListCustomer.aspx");
        }
    }
    }
