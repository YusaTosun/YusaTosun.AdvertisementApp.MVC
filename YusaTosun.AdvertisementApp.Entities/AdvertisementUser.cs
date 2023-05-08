using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class AdvertisementUser:BaseEntity
    {
        public int AdvertisementId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public int MilitaryStatus { get; set; }
        public int WorkExperience { get; set; }
        public string CvPath { get; set; }
    }
}
