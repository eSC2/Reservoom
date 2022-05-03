using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Services.ReservationCreators
{
    internal interface IReservationCreator
    {
        Task CreateReservation(Reservation reservation);
    }
}
