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
    /// Interaction logic for PlayersList.xaml
    /// </summary>
    public partial class PlayersList : Page
    {

        private UserViewModel _userViewModel;
        private SharedViewModel _sharedViewModel;

        public PlayersList(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _userViewModel = new UserViewModel(sharedViewModel);
            DataContext = _userViewModel;
            _sharedViewModel = sharedViewModel;

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                LoginOrRegister loginOrRegister = new LoginOrRegister(_sharedViewModel);
                NavigationService.Navigate(loginOrRegister);
            }
        }

        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
