using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.Model
{
    public class TriviaScores
    {
        private int bestScore;
        private int currentScore;
        private string playerEmail;

        public int BestScore
        {
            get
            {
                return bestScore;
            }
            set
            {
                bestScore = value;
                OnPropertyChanged("HighestScore");
            }
        }


        public int CurrentScore
        {
            get
            {
                return currentScore;
            }
            set
            {
                currentScore = value;
                OnPropertyChanged("LastScore");
            }
        }



        public String PlayerEmail
        {
            get
            {
                return playerEmail;
            }
            set
            {
                playerEmail = value;
                OnPropertyChanged("UserEmail");
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
