﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.UI.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        public string Name { get; }

        public PersonViewModel(string name)
        {
            Name = name;
        }
    }
}
