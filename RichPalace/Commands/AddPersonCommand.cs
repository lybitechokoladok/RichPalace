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
    public class AddPersonCommand : CommandBase
    {
        private readonly AddPersonViewModel _addPersonViewModel;
        private readonly PeopleStore _peopleStore;
        private readonly INavigationService _navigationService;

        public AddPersonCommand(AddPersonViewModel addPersonViewModel, PeopleStore peopleStore, INavigationService navigationService)
        {
            _addPersonViewModel = addPersonViewModel;
            _peopleStore = peopleStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            string name = _addPersonViewModel.Name;
            string role = _addPersonViewModel.Role;
            _peopleStore.AddPerson(name, role);

            _navigationService.Navigate();
        }
    }
}
