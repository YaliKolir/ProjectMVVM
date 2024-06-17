using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.Model
{
    public class TriviaQuestions
    {
        private string question;
        private string correctAnswer;
        private string answer2;
        private string answer3;
        private string answer4;


        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
                OnPropertyChanged("aQuestion");
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer = value;
                OnPropertyChanged("CorrectAnswer");
            }
        }

        public string Answer2
        {
            get
            {
                return answer2;
            }
            set
            {
                answer2 = value;
                OnPropertyChanged("Answer2");
            }
        }

        public string Answer3
        {
            get
            {
                return answer3;
            }
            set
            {
                answer3 = value;
                OnPropertyChanged("Answer3");
            }
        }

        public string Answer4
        {
            get
            {
                return answer4;
            }
            set
            {
                answer4 = value;
                OnPropertyChanged("Answer4");
            }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
