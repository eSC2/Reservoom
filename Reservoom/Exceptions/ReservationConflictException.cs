using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Exceptions
{
    internal class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncominggReservation { get; }


        public ReservationConflictException(Reservation existingReservation, Reservation incominggReservation)
        {
            ExistingReservation = existingReservation;
            IncominggReservation = incominggReservation;
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incominggReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncominggReservation = incominggReservation;
        }

        public ReservationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation incominggReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncominggReservation = incominggReservation;
        }
    }
}
