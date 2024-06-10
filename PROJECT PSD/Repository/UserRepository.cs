using PROJECT_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Repository
{
    public class UserRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();
        public static List<MsUser> GetAllUsers()
        {
            return db.MsUsers.ToList();
        }

        public static MsUser GetUserById(int id)
        {
            return db.MsUsers.Find(id);
        }
    }
}