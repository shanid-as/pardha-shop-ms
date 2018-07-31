using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Domain
{
    public class User
    {
        public long UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EncPassword { get; set; }
        public string Roles { get; set; }
    }
}
