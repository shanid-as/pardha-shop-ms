using PSMS.Domain;
using PSMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Business
{
    public class UserLogic
    {
        DataRepository objRepository = new DataRepository();

        public User ValidateAndSelectUser(string username, string encPassword)
        {
            return new User { Username = username, Roles = "superuser", UserID = 1 };
        }
    }
}
