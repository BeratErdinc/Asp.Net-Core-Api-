using System;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Repositories;

namespace HotelProject.DataAccessLayer.EntityFrameWork
{
    public class EfServiceDal : GenericRepositories<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }

    }
}
