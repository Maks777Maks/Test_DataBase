using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_DataBase.Entities
{
    public class DbUser : IdentityUser<string>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
        //public virtual ClientProfile ClientProfile { get; set; }
        //public virtual BrokerProfile BrokerProfile { get; set; }
        //public virtual AdminProfile AdminProfile { get; set; }
        //public virtual UserAccessLock UserAccessLock { get; set; }   
    }
}
