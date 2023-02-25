using RichPalace.Domain.Models;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class ClientDetailsViewModel : ViewModelBase
    {
        private readonly SelectedClientStore _selectedClientStore;
        private Client SelectedClient => _selectedClientStore.SelectedClient;


        public bool HasSelectedClient => SelectedClient != null;
        public string Username =>SelectedClient?.Username ?? "Unknown";
        public string Email => SelectedClient?.Email;

        public ClientDetailsViewModel(SelectedClientStore selectedClientStore)
        {
            _selectedClientStore = selectedClientStore;

            _selectedClientStore.SelectedClientChanged += SelectedClientChanged;
        }
        public override void Dispose()
        {
            _selectedClientStore.SelectedClientChanged -= SelectedClientChanged;

            base.Dispose();
        }

        private void SelectedClientChanged()
        {
            OnPropertyChanged(nameof(HasSelectedClient));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(Email));
        }
    }
}
