using ProjectMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVVM.ViewModel
{
    public class TriviaQuestionsViewModel
    {
        private SharedViewModel _sharedViewModel;

        public TriviaQuestionsViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;
        }
        public List<TriviaQuestions> Questions
        {
            get { return _sharedViewModel.QuestionList; }
        }
    }
}
