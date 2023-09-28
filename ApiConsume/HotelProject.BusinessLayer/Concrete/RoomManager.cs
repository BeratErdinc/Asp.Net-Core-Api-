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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal roomda;
        public RoomManager(IRoomDal roomService) { roomda = roomService; }
        public void TDelete(Room t)
        {
            roomda.Delete(t);

        }

        public Room TGetById(int id)
        {
            return roomda.GetById(id);
        }

        public List<Room> TGetList()
        {
            return roomda.GetList();
        }

        public void TInsert(Room t)
        {
            roomda.Insert(t);
        }

        public void TUpdate(Room t)
        {
            roomda.Update(t);
        }
    }
}
