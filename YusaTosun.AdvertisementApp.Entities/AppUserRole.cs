﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Entities
{
    public class AppUserRole : BaseEntity
    {
        public int AppUserId { get; set; }
        public AppUser User { get; set; }
        public int AppRoleId { get; set; }
        public AppRole Role { get; set; }
    }
}
