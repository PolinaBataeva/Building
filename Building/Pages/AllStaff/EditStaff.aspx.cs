using Building.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Building.Pages.AllStaff
{
    public partial class EditStaff : System.Web.UI.Page
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
            Staff staff = DataAccessor.SelectStaff(id);
            TextBoxFIO.Text = staff.FIO.ToString();
            TextBoxPost.Text = staff.Post.ToString();
            TextBoxDateOfBirth.Text = staff.DateOfBirth != null ? staff.DateOfBirth.Value.ToShortDateString() : string.Empty;
            TextBoxDateOfHiring.Text = staff.DateOfHiring != null ? staff.DateOfHiring.Value.ToShortDateString() : string.Empty;
            TextBoxPhoneNumb.Text = staff.PhoneNumb.ToString();

        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.IdStaff = id;
            staff.FIO = TextBoxFIO.Text;
            staff.Post = TextBoxPost.Text;
            staff.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text);
            staff.DateOfHiring = DateTime.Parse(TextBoxDateOfHiring.Text);
            staff.PhoneNumb = TextBoxPhoneNumb.Text;
            Response.Redirect("~/Pages/AllStaff/ListStaff.aspx");
        }
    }
}