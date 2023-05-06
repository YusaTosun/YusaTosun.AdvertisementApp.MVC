﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class Advertisement:BaseEntities
    {
        public string Title { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }

        public DateTime CreatedTime { get; set; }
        public List<AdvertisementUser> AdvertisementUsers { get; set; }
    }
}
