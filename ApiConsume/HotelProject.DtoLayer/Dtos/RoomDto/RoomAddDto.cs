using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
   public class RoomAddDto
    {
        [Required(ErrorMessage = "Please write the room number")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter price information")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter room title information")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of beds")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathrooms")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
