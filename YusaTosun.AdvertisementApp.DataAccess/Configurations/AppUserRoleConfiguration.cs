﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YusaTosun.AdvertisementApp.Entities;

namespace YusaTosun.AdvertisementApp.DataAccess.Configurations
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasIndex(x =>
            new
            {
                x.AppUserId,
                x.AppRoleId
            }).IsUnique();

            builder.HasOne(x=>x.AppRole).WithMany(x=>x.AppUserRoles).HasForeignKey(x=>x.AppRoleId);
            builder.HasOne(x=>x.AppUser).WithMany(x=>x.AppUserRoles).HasForeignKey(x=>x.AppUserId);
        }
    }
}
