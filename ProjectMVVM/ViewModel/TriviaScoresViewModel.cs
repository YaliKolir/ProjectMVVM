using ProjectMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.ViewModel
{
    public class TriviaScoresViewModel
    {
        private SharedViewModel _sharedViewModel;

        public TriviaScoresViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<TriviaScores> Scores
        {
            get { return _sharedViewModel.TriviaScoresList; }
        }

    }
}
