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
    /// Interaction logic for TriviaQuestionsList.xaml
    /// </summary>
    public partial class TriviaQuestionsList : Page
    {
        private SharedViewModel _sharedViewModel;
        private TriviaQuestionsViewModel _questionViewModel;
        public TriviaQuestionsList(SharedViewModel sharedViewModel)
        {
            InitializeComponent();

            _sharedViewModel = sharedViewModel;
            _questionViewModel = new TriviaQuestionsViewModel(sharedViewModel);
            DataContext = _questionViewModel;


            if (_sharedViewModel.QuestionList == null || _sharedViewModel.QuestionList.Count == 0)
            {
                _sharedViewModel.QuestionList = new List<TriviaQuestions>
            {
new TriviaQuestions { Question = "Which language is the most spoken worldwide?", CorrectAnswer = "Mandarin Chinese", Answer2 = "Spanish", Answer3 = "English", Answer4 = "Hindi" },
new TriviaQuestions { Question = "What is the largest planet in our solar system?", CorrectAnswer = "Jupiter", Answer2 = "Saturn", Answer3 = "Neptune", Answer4 = "Earth" },
new TriviaQuestions { Question = "Who discovered penicillin?", CorrectAnswer = "Alexander Fleming", Answer2 = "Marie Curie", Answer3 = "Louis Pasteur", Answer4 = "Isaac Newton" },
new TriviaQuestions { Question = "In what year did World War II end?", CorrectAnswer = "1945", Answer2 = "1939", Answer3 = "1940", Answer4 = "1950" },
new TriviaQuestions { Question = "What is the hardest natural substance on Earth?", CorrectAnswer = "Diamond", Answer2 = "Gold", Answer3 = "Iron", Answer4 = "Quartz" },
new TriviaQuestions { Question = "Who was the first President of the United States?", CorrectAnswer = "George Washington", Answer2 = "Thomas Jefferson", Answer3 = "Abraham Lincoln", Answer4 = "John Adams" },
new TriviaQuestions { Question = "What is the chemical symbol for water?", CorrectAnswer = "H2O", Answer2 = "O2", Answer3 = "CO2", Answer4 = "NaCl" },
new TriviaQuestions { Question = "Which country hosted the 2016 Summer Olympics?", CorrectAnswer = "Brazil", Answer2 = "China", Answer3 = "United Kingdom", Answer4 = "Russia" },
new TriviaQuestions { Question = "How many bones are in the adult human body?", CorrectAnswer = "206", Answer2 = "201", Answer3 = "210", Answer4 = "215" },
new TriviaQuestions { Question = "What is the main ingredient in traditional Japanese miso soup?", CorrectAnswer = "Fermented soybeans", Answer2 = "Rice", Answer3 = "Seaweed", Answer4 = "Fish" }
    };
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

        private void QuestionsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
