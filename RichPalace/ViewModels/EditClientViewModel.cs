using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class EditClientViewModel : ViewModelBase
    {
        public ClientDetailsFormViewModel ClientDetailsFormViewModel { get; set; }

        public EditClientViewModel()
        {
            ClientDetailsFormViewModel= new ClientDetailsFormViewModel();
        }

    }
}
