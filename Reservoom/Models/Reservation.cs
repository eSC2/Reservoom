using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    internal class Reservation
    {
        public string Username { get; }
        public RoomID RoomID { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Length => EndDate.Subtract(StartDate);

        public Reservation(string username, RoomID roomID, DateTime startDate, DateTime endDate)
        {
            Username = username;
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
