using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Dto.Layer.Dtos.RoomDtos
{
    public class UpdateRoomDto
    {

        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }

        public string RoomImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyatı yazınız")]
        public int Price { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısını yazınız")]
        public string BadCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
