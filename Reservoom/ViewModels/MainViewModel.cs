﻿using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            //CurrentViewModel = new MakeReservationViewModel(hotel);    
            CurrentViewModel = new ReservationListingViewModel();    
        }
    }
}
