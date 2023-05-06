using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class AppRole:BaseEntities
    {
        public string Definition { get; set; }
        public List<AppUserRole> UserRoles { get; set; }
    }
}
