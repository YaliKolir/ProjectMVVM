using ProjectMVVM.Model;
using Microsoft.Win32;
using ProjectMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectMVVM.View
{
    /// <summary>
    /// Interaction logic for LoginOrRegister.xaml
    /// </summary>
    public partial class LoginOrRegister : Page
    {
        public SharedViewModel _sharedViewModel;

        public LoginOrRegister(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
        }
        public LoginOrRegister()
        {
            InitializeComponent();
            this._sharedViewModel = new SharedViewModel();
            if (_sharedViewModel.UsersList == null || _sharedViewModel.UsersList.Count == 0)
            {
                _sharedViewModel.UsersList = new List<Player>
            {
                new Player { UserId = 0, FirstName = "admin", LastName = "admin", Email = "admin@example.com", Password = "password0"}
            };
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                Login login = new Login(_sharedViewModel);
                NavigationService.Navigate(login);

            }
        }

        private void SendToRegister_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                Register register = new Register(_sharedViewModel);
                NavigationService.Navigate(register);

            }
        }

        private void MainFrame_Navigated_1(object sender, NavigationEventArgs e)
        {

        }
    }
}
