using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class AppUser : BaseEntities
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }
}
