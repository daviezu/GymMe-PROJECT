using PROJECT_PSD.Controller;
using PROJECT_PSD.Models;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = Session["User"] as MsUser;

            if (!IsPostBack)
            {
                if (user != null)

                {
                    string role = GetCurrentUserRole();
                    lblRole.Text = $"Your role is {user.UserRole}";

                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        CustomerGV.Visible = true;
                        LoadCustomerData();
                    }
                }
                else
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        private string GetCurrentUserRole()
        {
            MsUser user = Session["User"] as MsUser;
            if (user != null)
            {
                //FormsIdentity id = (FormsIdentity)User.Identity;
                //FormsAuthenticationTicket ticket = id.Ticket;
                //return ticket.UserData;
                return user.UserRole;
            }
            return string.Empty;
        }

        private void LoadCustomerData()
        {
            var customers = UserRepository.GetAllCustomers();
            CustomerGV.DataSource = customers;
            CustomerGV.DataBind();
        }
    }
}