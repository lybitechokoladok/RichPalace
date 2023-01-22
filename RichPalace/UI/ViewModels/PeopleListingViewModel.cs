using RichPalace.BL.Services;
using RichPalace.UI.Commands;
using RichPalace.UI.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RichPalace.UI.ViewModels
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

            _people.Add(new PersonViewModel("Angela"));
            _people.Add(new PersonViewModel("Georgy"));
            _people.Add(new PersonViewModel("Zina"));

            _peopleStore.PersonAdded += OnPersonAdded;
        }

        private void OnPersonAdded(string name)
        {
            _people.Add(new PersonViewModel(name));
        }
    }
}
