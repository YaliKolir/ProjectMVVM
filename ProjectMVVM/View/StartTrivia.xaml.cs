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
    /// Interaction logic for StartTrivia.xaml
    /// </summary>
    public partial class StartTrivia : Page
    {
        private SharedViewModel _sharedViewModel;
        public StartTrivia(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
        }



        private void StartPlaying_Click(object sender, RoutedEventArgs e)
        {


            TriviaGamePage triviaGame = new TriviaGamePage(_sharedViewModel, _sharedViewModel.returnQuestions());
            NavigationService.Navigate(triviaGame);

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
