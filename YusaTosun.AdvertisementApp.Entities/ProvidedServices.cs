using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class ProvidedServices:BaseEntity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Definition { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
