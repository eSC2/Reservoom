using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    internal class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string Username => _reservation.Username;
        public string RoomID => _reservation.RoomID?.ToString();
        public string StartDate => _reservation.StartDate.Date.ToString("d");
        public string EndDate => _reservation.EndDate.Date.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
