using System;
using ProjectMVVM.Model;
using ProjectMVVM.ViewModel;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {

        public SharedViewModel _sharedViewModel;
        public Admin(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
            InitializeComponent();
        }



        private void QuestionsAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                TriviaQuestionsList triviaList = new TriviaQuestionsList(_sharedViewModel);
                NavigationService.Navigate(triviaList);
            }
        }

        private void PlayersAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                PlayersList players = new PlayersList(_sharedViewModel);
                NavigationService.Navigate(players);
            }
        }


        private void ScoresAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                TriviaScoresList scoreList = new TriviaScoresList(_sharedViewModel);
                NavigationService.Navigate(scoreList);
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
