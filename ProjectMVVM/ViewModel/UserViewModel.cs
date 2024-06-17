using ProjectMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.ViewModel
{
    public class UserViewModel
    {
        private SharedViewModel _sharedViewModel;

        public UserViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<Player> Users
        {
            get { return _sharedViewModel.UsersList; }
        }
    }
}