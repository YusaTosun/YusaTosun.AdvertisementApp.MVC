using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YusaTosun.AdvertisementApp.Entities;

namespace YusaTosun.AdvertisementApp.DataAccess.Configurations
{
    public class ProvidedServicesConfiguration : IEntityTypeConfiguration<ProvidedServices>
    {
        public void Configure(EntityTypeBuilder<ProvidedServices> builder)
        {
            builder.Property(x=>x.Definition).HasColumnType("ntext").IsRequired();
            builder.Property(x=>x.ImagePath).HasMaxLength(500).IsRequired();
            builder.Property(x=>x.Title).HasMaxLength(300).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
        }
    }
}
