using PROJECT_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class ReportRepository
    {
        private static LocalDatabaseEntities db = new LocalDatabaseEntities();

        public static List<TransactionHeader> GetAllTrHeaders()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}