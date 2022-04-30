using Reservoom.Exceptions;
using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("SingletonSean Suites");

            try
            {
                hotel.MakeReservation(new Reservation("eSC2", new RoomID(1, 2), new DateTime(2022, 1, 4), new DateTime(2022, 3, 4)));
                hotel.MakeReservation(new Reservation("eSC2", new RoomID(1, 2), new DateTime(2022, 1, 4), new DateTime(2022, 2, 4)));
            }
            catch (ReservationConflictException ex)
            {

            }



            IEnumerable<Reservation> myReservations = hotel.GetReservations();

            base.OnStartup(e);
        }
    }
}
