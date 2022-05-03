﻿using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Services.ReservationProviders
{
    internal interface IReservationProvider
    {
        Task<IEnumerable<Reservation>> GetReservations();
    }
}
