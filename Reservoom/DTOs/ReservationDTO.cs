using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.DTOs
{
    internal class ReservationDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
