using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LoginRepository : ILoginRepository
    {
        private MyCmsContext db;
        public LoginRepository(MyCmsContext context)
        {
            db = context;
        }
        public bool IsUserValid(string username, string password)
        {
            return db.AdminLogins.Any(u => u.Username == username && u.Password == password);
        }
    }
}
