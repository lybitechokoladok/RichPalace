using RichPalace.Domain.Models;
using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Stores
{
    public class ClientStore
    {

        public event Action<Client> ClientAdded;
        public event Action SelectedCLientChanged;

        private Client _selectedClient;

        public Client  SelectedClient
        {
            get => _selectedClient;
            set 
            {
                _selectedClient = value;
                SelectedCLientChanged?.Invoke();
            }
        }

        public void AddClient(Client client)
        {
            ClientAdded?.Invoke(client);
        }
    }
}
