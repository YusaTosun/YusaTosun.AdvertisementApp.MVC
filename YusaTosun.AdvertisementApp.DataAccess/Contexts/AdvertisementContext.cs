using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YusaTosun.AdvertisementApp.DataAccess.Configurations;
using YusaTosun.AdvertisementApp.Entities;

namespace YusaTosun.AdvertisementApp.DataAccess.Contexts
{
    public class AdvertisementContext:DbContext
    {
        public AdvertisementContext(DbContextOptions<AdvertisementContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdvertisementAppUserConfiguration()).ApplyConfiguration(new AdvertisementAppUserStatusConfiguration()).ApplyConfiguration(new AdvertisementConfiguration()).ApplyConfiguration(new AppRoleConfiguration()).ApplyConfiguration(new AppUserConfiguration()).ApplyConfiguration(new AppUserRoleConfiguration()).ApplyConfiguration(new GenderConfiguration()).ApplyConfiguration(new MilitaryStatusConfiguration()).ApplyConfiguration(new ProvidedServicesConfiguration());
        }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdvertisementAppUser> AdvertisementAppUsers { get; set; }
        public DbSet<AdvertisementAppUserStatus> AdvertisementAppUserStatuses { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
        public DbSet<ProvidedServices> ProvidedServiceses { get; set; }
    }
}
