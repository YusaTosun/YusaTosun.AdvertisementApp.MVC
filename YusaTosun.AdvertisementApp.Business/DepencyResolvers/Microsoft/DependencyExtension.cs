using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YusaTosun.AdvertisementApp.DataAccess.Contexts;
using YusaTosun.AdvertisementApp.DataAccess.UnitOfWork;

namespace YusaTosun.AdvertisementApp.Business.DepencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer("Server=YUSATOSUN\\SQLEXPRESS;Database=AdvertisementDB;Trusted_Connection=True");
            });
            var mapperConfiguration = new MapperConfiguration(opt =>
            {

            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IUow, Uow>();
        }
    }
}
