using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please write the room number")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please enter room image")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter price information")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter room title information")]
        [StringLength(100, ErrorMessage = "Please enter a maximum of 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the number of beds")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the number of bathrooms")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please write the description")]
        public string Description { get; set; }
    }
}
