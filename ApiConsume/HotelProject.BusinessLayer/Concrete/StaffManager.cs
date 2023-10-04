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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffService;

        public StaffManager(IStaffDal staffdal)
        {
            _staffService = staffdal;
        }

        public void TDelete(Staff t)
        {
            _staffService.Delete(t);
        }

        public Staff TGetById(int id)
        {
            return _staffService.GetById(id);
        }

        public List<Staff> TGetList()
        {
          return _staffService.GetList();
        }

        public void TInsert(Staff t)
        {
           _staffService.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffService.Update(t);
        }
    }
}
