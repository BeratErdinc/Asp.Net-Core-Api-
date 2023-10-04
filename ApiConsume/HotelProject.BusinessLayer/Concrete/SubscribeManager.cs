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
    public class SubscribeManager : ISubscribeService
    {
        private readonly  ISubscribeDal _subscribeService;

        public  SubscribeManager(ISubscribeDal subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public void TDelete(Subscribe t)
        {
            _subscribeService.Delete(t);

        }

        public Subscribe TGetById(int id)
        {
           return _subscribeService.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
           return _subscribeService.GetList();

        }

        public void TInsert(Subscribe t)
        {
            _subscribeService.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            
            _subscribeService.Update(t);
        }
    }
}
