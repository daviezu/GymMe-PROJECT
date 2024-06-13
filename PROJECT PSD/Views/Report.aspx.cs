using PROJECT_PSD.DataSet;
using PROJECT_PSD.Handler;
using PROJECT_PSD.Models;
using PROJECT_PSD.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD.Views
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Bikin report baru
            CrystalReport1 report = new CrystalReport1();

            // Set Report Source dari viewer
            CrystalReportViewer1.ReportSource = report;

            // Ambil datanya
            List<TransactionHeader> headers = ReportHandler.GetAllTransactionHeader();

            ReportDataSet data = GetDataSet(headers);

            report.SetDataSource(data);
        }

        private ReportDataSet GetDataSet(List<TransactionHeader> headers)
        {
            ReportDataSet data = new ReportDataSet();

            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            foreach(TransactionHeader h in headers)
            {
                var header_row = headerTable.NewRow();
                header_row["TransactionID"] = h.TransactionID;
                header_row["UserID"] = h.UserID;
                header_row["TransactionDate"] = h.TransactionDate;
                header_row["Status"] = h.Status;

                headerTable.Rows.Add(header_row);

                List<TransactionDetail> details = GetTransactionDetails(h.TransactionID);
                foreach (TransactionDetail d in details)
                {
                    var detail_row = detailTable.NewRow();

                    detail_row["TransactionID"] = d.TransactionID;
                    detail_row["SupplementID"] = d.SupplementID;
                    detail_row["Quantity"] = d.Quantity;

                    detailTable.Rows.Add(detail_row);

                }
            }
            return data;
        }

        private List<TransactionDetail> GetTransactionDetails(int transactionID)
        {
            using (var context = new LocalDatabaseEntities())
            {
                return context.TransactionDetails.Where(d => d.TransactionID == transactionID).ToList();
            }
        }
    }
}

