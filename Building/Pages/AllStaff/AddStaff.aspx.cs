using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllStaff
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) ;
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.FIO = TextBoxFIO.Text;
            staff.Post = TextBoxPost.Text;
            staff.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text);
            staff.DateOfHiring = DateTime.Parse(TextBoxDateOfHiring.Text);
            staff.PhoneNumb = TextBoxPhoneNumb.Text;
            Response.Redirect("~/Pages/AllStaff/ListStaff.aspx");
        }
    }
}