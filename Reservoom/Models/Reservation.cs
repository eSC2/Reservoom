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
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(string username, RoomID roomID, DateTime startTime, DateTime endTime)
        {
            Username = username;
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
        }

        internal bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
