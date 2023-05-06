using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class Gender
    {
        public string Definition { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
