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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = Convert.ToInt32(Request.QueryString["ID"]);
                MsUser user = UserRepository.GetUserById(userid);

                List<TransactionHeader> list;
                /*if (user.UserRole == "Admin")
                {*/
                list = TransactionRepository.GetAllTransactionHeader();
                /* }
                 else
                 {

                 }*/
                //bikin role permission


                TransactionHistoryGV.DataSource = list;
                TransactionHistoryGV.DataBind();

            }

        }

        protected void Detail_btn_Click(object sender, EventArgs e)
        {

            int transactionID = Convert.ToInt32((sender as Button).CommandArgument);
            Response.Redirect("~/Views/TransactionDetailPage.aspx?ID=" + transactionID);
        }
    }
}