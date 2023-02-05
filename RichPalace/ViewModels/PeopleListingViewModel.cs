using RichPalace.WPF.Services;
using RichPalace.WPF.Commands;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RichPalace.WPF.ViewModels
{
    public class PeopleListingViewModel : ViewModelBase
    {
        private readonly PeopleStore _peopleStore;

        private readonly ObservableCollection<PersonViewModel> _people;

        public IEnumerable<PersonViewModel> People => _people;

        public ICommand AddPersonCommand { get; }

        public PeopleListingViewModel(PeopleStore peopleStore, INavigationService addPersonNavigationService)
        {
            _peopleStore = peopleStore;

            AddPersonCommand = new NavigateCommand(addPersonNavigationService);
            _people = new ObservableCollection<PersonViewModel>();

            _people.Add(new PersonViewModel("Angela", "admin"));
            _people.Add(new PersonViewModel("Georgy",  "admin"));
            _people.Add(new PersonViewModel("Zina", "admin"));

            _peopleStore.PersonAdded += OnPersonAdded;
        }

        private void OnPersonAdded(string name, string role)
        {
            _people.Add(new PersonViewModel(name, role));
        }
    }
}
