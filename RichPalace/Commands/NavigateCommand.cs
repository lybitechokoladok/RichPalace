using RichPalace.WPF.Services;
using RichPalace.Domain.Models;
using RichPalace.WPF.Stores;
using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Commands
{
    public class NavigateCommand : CommandBase
    {

        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
