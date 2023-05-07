using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YusaTosun.AdvertisementApp.Entities;

namespace YusaTosun.AdvertisementApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
    }
}
