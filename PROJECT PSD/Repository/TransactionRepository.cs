using PROJECT_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class TransactionRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();

        public static List<TransactionDetail> GetAllTransactionDetail()
        {
            List<TransactionDetail> transactionDetail = db.TransactionDetails.ToList();
            return transactionDetail;
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            List<TransactionHeader> transactionHeaders = db.TransactionHeaders.ToList();
            return transactionHeaders;
        }

        public static List<TransactionDetail> GetTransactionDetailsByHeaderId(int id)
        {
            return (from transaction in db.TransactionDetails where transaction.TransactionID == id select transaction).ToList();

        }

        public static TransactionHeader GetTransactionHeaderById(int id)
        {
            TransactionHeader getTransactionHeader = (from transaction in db.TransactionHeaders where transaction.TransactionID == id select transaction).FirstOrDefault();
            return getTransactionHeader;
        }
    }
}