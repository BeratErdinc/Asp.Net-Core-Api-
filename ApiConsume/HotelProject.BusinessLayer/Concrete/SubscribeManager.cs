using HotelProject.BusinessLayer.Abstract;
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
        private readonly ISubscribeService _subscribeService;

        public SubscribeManager(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public void TDelete(Subscribe t)
        {
            _subscribeService.TDelete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribeService.TGetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeService.TGetList();
        }

        public void TInsert(Subscribe t)
        {
           _subscribeService.TInsert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeService.TUpdate(t);
        }
    }
}
