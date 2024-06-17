using ProjectMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.ViewModel
{
    public class SharedViewModel
    {
        private List<TriviaScores> _scoreList;
        private List<Player> _playersList;
        private List<TriviaQuestions> _triviaQuestions;
        private string loggedInUserEmail;
        public SharedViewModel()
        {
            _scoreList = new List<TriviaScores>();
            _playersList = new List<Player>();
            _triviaQuestions = new List<TriviaQuestions>();
        }

        public List<TriviaScores> TriviaScoresList
        {
            get { return _scoreList; }
            set { _scoreList = value; }
        }

        public List<Player> UsersList
        {
            get { return _playersList; }
            set { _playersList = value; }
        }

        public List<TriviaQuestions> QuestionList
        {
            get { return _triviaQuestions; }
            set { _triviaQuestions = value; }
        }


        public void setLoggedInUserEmail(string email)
        {
            this.loggedInUserEmail = email;
        }

        public bool IsEmailInList(string email)
        {
            foreach (Player user in this._playersList)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;

        }

        public List<TriviaQuestions> returnQuestions()
        {
            List<TriviaQuestions> list = new List<TriviaQuestions>();
            for (int i = 0; i < this.QuestionList.Count; i++)
            {
                list.Add(this.QuestionList[i]);
            }
            return list;
        }

        public TriviaScores returnScore()
        {
            foreach (TriviaScores triviaScore in this._scoreList)
            {
                if (triviaScore.PlayerEmail == loggedInUserEmail)
                {
                    return triviaScore;
                }
            }
            // if here, we did not find score, adding one
            TriviaScores newScore = new TriviaScores { PlayerEmail = loggedInUserEmail, CurrentScore = 0, BestScore = 0 };
            this._scoreList.Add(newScore);
            return newScore;
        }

        public Player returnPlayer(string email)
        {
            foreach (Player player in this._playersList)
            {
                if (player.Email == email)
                {
                    return player;
                }
            }
            return null;
        }

    }
}
