using RichPalace.BL.Services;
using RichPalace.Domain.Models;
using RichPalace.UI.Stores;
using RichPalace.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.UI.Commands
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
