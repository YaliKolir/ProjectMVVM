using ProjectMVVM.ViewModel;
using ProjectMVVM.Model;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            this.sharedViewModel = sharedViewModel;
        }

        public SharedViewModel sharedViewModel { get; }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Player user = sharedViewModel.returnPlayer(EmailOfUser.Text);

            if (user != null)
            {
                if (user.Password == PasswordOfUser.Text)
                {
                    if (user.Password == "password0" && user.Email == "admin@example.com")
                    {
                        if (NavigationService != null)
                        {
                            Admin admindSelect = new Admin(sharedViewModel);
                            NavigationService.Navigate(admindSelect);
                            MessageBox.Show("Welcome " + user.FirstName);
                        }
                    }
                    else
                    {

                        if (NavigationService != null)
                        {
                            sharedViewModel.setLoggedInUserEmail(EmailOfUser.Text);
                            StartTrivia triviaStart = new StartTrivia(sharedViewModel);
                            NavigationService.Navigate(triviaStart);
                            MessageBox.Show("Welcome " + user.FirstName);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password or email");
                }
            }
            else
            {
                MessageBox.Show("Wrong password or email");
            }

        }

        private void EmailOfUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                LoginOrRegister loginOrRegister = new LoginOrRegister(sharedViewModel);
                NavigationService.Navigate(loginOrRegister);
            }
        }

        private void PasswordOfUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

