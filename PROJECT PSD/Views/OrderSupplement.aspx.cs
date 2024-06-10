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
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<MsSupplement> supplements = SupplementRepository.GetAllSupplements();

                List<MsSupplementType> supplementTypes = SupplementRepository.GetAllSupplementTypes();

                var supplementData = from s in supplements
                                     join st in supplementTypes on s.SupplementTypeID equals st.SupplementTypeID
                                     select new
                                     {
                                         s.SupplementID,
                                         s.SupplementName,
                                         s.SupplementExpiryDate,
                                         s.SupplementPrice,
                                         st.SupplementTypeID,
                                         st.SupplementTypeName
                                     };


                OrderSupplementGV.DataSource = supplementData;
                OrderSupplementGV.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void addToCartbtn_Click(object sender, EventArgs e)
        {

        }
    }
}