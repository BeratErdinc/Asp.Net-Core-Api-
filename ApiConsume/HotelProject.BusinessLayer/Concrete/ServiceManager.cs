using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServicesService
    {
        private readonly IServicesDal _ServicesDal;
        public ServiceManager(IServicesDal ServicesDal)
        {
            _ServicesDal = ServicesDal;
        }

        public void TDelete(Service t)
        {
            _ServicesDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _ServicesDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _ServicesDal.GetList();
        }

        public void TInsert(Service t)
        {
            _ServicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _ServicesDal.Update(t);
        }
    }
}
