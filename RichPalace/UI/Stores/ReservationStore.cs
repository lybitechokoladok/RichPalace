﻿using RichPalace.Domain.Models;
using RichPalace.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.UI.Stores
{
    public class ReservationStore
    {
        private ViewModelBase _reservations;

        public ViewModelBase Reservations
        {
            get => _reservations;
            set 
            {
                _reservations = value; 
                OnRservationAdded();
            }
        }


        public event Action ReservationAdded;

        public void OnRservationAdded() 
        {
            ReservationAdded?.Invoke();
        }
    }
}
