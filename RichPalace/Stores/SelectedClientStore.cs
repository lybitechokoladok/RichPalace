using RichPalace.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Stores
{
    public class SelectedClientStore
    {
		private Client _selectedClient;
		public Client SelectedClient
		{
			get { return _selectedClient; }
			set 
			{
				_selectedClient = value;
				SelectedClientChanged?.Invoke();
			}
		}

		public event Action SelectedClientChanged;

	}
}
