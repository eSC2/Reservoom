using Reservoom.Commands;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom.ViewModels
{
    internal class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand();

            _reservations.Add(new ReservationViewModel(new Reservation("eSC2", new RoomID(1, 2), new DateTime(2022, 1, 4), new DateTime(2022, 3, 4))));
            _reservations.Add(new ReservationViewModel(new Reservation("Quantm", new RoomID(2, 2), new DateTime(2022, 1, 4), new DateTime(2022, 3, 4))));
            _reservations.Add(new ReservationViewModel(new Reservation("Naito", new RoomID(1, 4), new DateTime(2022, 1, 4), new DateTime(2022, 3, 4))));

        }
    }
}
