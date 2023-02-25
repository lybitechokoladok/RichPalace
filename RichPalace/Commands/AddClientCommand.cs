using RichPalace.Domain.Models;
using RichPalace.WPF.Services;
using RichPalace.WPF.Stores;
using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Commands
{
    public class AddClientCommand : CommandBase
    {
        private readonly AddClientViewModel _addClientViewModel;
        private readonly ClientStore _peopleStore;
        private readonly INavigationService _navigationService;

        public AddClientCommand(AddClientViewModel addPersonViewModel, ClientStore peopleStore, INavigationService navigationService)
        {
            _addClientViewModel = addPersonViewModel;
            _peopleStore = peopleStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
        }
    }
}
