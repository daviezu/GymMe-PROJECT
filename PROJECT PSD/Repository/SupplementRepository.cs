using PROJECT_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class SupplementRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();

        public static List<MsSupplement> GetAllSupplements()
        {
            return db.MsSupplements.ToList();

        }

        public static List<MsSupplementType> GetAllSupplementTypes()
        {

            return db.MsSupplementTypes.ToList();
        }
        public static MsSupplement GetSupplementByID(int id)
        {
            MsSupplement supplementToFind = (from supplement in db.MsSupplements where supplement.SupplementID == id select supplement).ToList().FirstOrDefault();
            return supplementToFind;
        }

        public static MsSupplementType GetSupplementTypeByID(int id)
        {
            MsSupplementType supplementTypeToFind = (from supplement in db.MsSupplementTypes where supplement.SupplementTypeID == id select supplement).ToList().FirstOrDefault();
            return supplementTypeToFind;
        }
    }
}