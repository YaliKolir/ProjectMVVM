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
    /// Interaction logic for TriviaGamePage.xaml
    /// </summary>
    public partial class TriviaGamePage : Page
    {
        public SharedViewModel _sharedViewModel;
        public List<TriviaQuestions> _list;
        private int questionIndex = 0;
        private string expectedAnswer;
        private int currentScore = 0;

        public TriviaGamePage(SharedViewModel sharedViewModel, List<TriviaQuestions> list)
        {
            InitializeComponent();

            _sharedViewModel = sharedViewModel;
            _list = list;
            fillPage(_list[questionIndex]);
        }


        public void fillPage(TriviaQuestions question)
        {
            int[] array = { 0, 1, 2, 3 };
            string[] answers = new string[] { question.CorrectAnswer, question.Answer2, question.Answer3, question.Answer4 };

            this.expectedAnswer = question.CorrectAnswer;

            Random rnd = new Random();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int index = rnd.Next(0, i + 1);
                int temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }

            answer1.Content = answers[array[0]];
            answer2.Content = answers[array[1]];
            answer3.Content = answers[array[2]];
            answer4.Content = answers[array[3]];

            TextBlock textBlock = FindName("question") as TextBlock;
            textBlock.Text = question.Question;


        }



        private void updateScore()
        {
            currentScore++;
        }

        private void pageLoader()
        {
            questionIndex++;

            if (questionIndex == _list.Count)
            {
                TriviaScores score = _sharedViewModel.returnScore();

                if (currentScore > score.BestScore)
                {
                    score.BestScore = currentScore;
                }
                score.CurrentScore = currentScore;



                if (NavigationService != null)
                {
                    FinalPage finishingPage = new FinalPage(_sharedViewModel);
                    finishingPage.ScoreCounter.Text = $"Your score is {currentScore.ToString()}";
                    NavigationService.Navigate(finishingPage);
                    return;
                }

            }


            fillPage(_list[questionIndex]);
        }

        private void answer1_Click(object sender, RoutedEventArgs e)
        {

            if (answer1.Content == this.expectedAnswer)
            {
                updateScore();

            }

            pageLoader();

        }

        private void answer2_Click(object sender, RoutedEventArgs e)
        {
            if (answer2.Content == this.expectedAnswer)
            {
                updateScore();
            }
            pageLoader();
        }

        private void answer3_Click(object sender, RoutedEventArgs e)
        {
            if (answer3.Content == this.expectedAnswer)
            {
                updateScore();
            }
            pageLoader();
        }

        private void answer4_Click(object sender, RoutedEventArgs e)
        {
            if (answer4.Content == this.expectedAnswer)
            {
                updateScore();
            }
            pageLoader();
        }



    }
}
