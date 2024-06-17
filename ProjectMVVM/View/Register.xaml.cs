using ProjectMVVM.Model;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {

        private static int UserIdCounter = 10;
        public Register(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;

        }
        public SharedViewModel _sharedViewModel;


        private bool ContainsUpperCase(string input)
        {
            // Check if any character in the string is an uppercase letter
            return input.Any(char.IsUpper);
        }

        private bool ContainsNumber(string input)
        {
            // Check if any character in the string is an uppercase letter
            return input.Any(char.IsDigit);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_sharedViewModel.IsEmailInList(EmailOfUser.Text) == false)
            {
                if (ContainsNumber(PasswordOfUser.Text) == true)  //checks if the password conditions are ok
                {
                    if (ContainsUpperCase(PasswordOfUser.Text) == true)
                    {
                        if (PasswordOfUser.Text.Length >= 6 && PasswordOfUser.Text.Length <= 10)
                        {
                            if (PasswordOfUser.Text == ConfirmPassword.Text)
                            {
                                UserIdCounter += 1;

                                _sharedViewModel.UsersList.Add(new Player { UserId = UserIdCounter, FirstName = NameOfUser.Text, LastName = LastNameOfUser.Text, Email = EmailOfUser.Text, Password = PasswordOfUser.Text });

                                if (NavigationService != null)
                                {
                                    Login login = new Login(_sharedViewModel);
                                    NavigationService.Navigate(login);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Passwords are not the same");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Length has to be between 6 and 10 letters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You need at least one upper case letter");
                    }
                }
                else
                {
                    MessageBox.Show("You need at least one number");
                }

            }
            else
            {
                MessageBox.Show("Email is already used");
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                LoginOrRegister loginOrRegister = new LoginOrRegister(_sharedViewModel);
                NavigationService.Navigate(loginOrRegister);
            }
        }
    }
}
