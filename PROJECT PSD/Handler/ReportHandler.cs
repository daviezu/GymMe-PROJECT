using PROJECT_PSD.Models;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class ReportHandler
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return ReportRepository.GetAllTrHeaders();
        }
    }
}