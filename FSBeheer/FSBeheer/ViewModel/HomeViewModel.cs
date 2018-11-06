using FSBeheer.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;

namespace FSBeheer.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ObservableCollection<QuestionVM> Questions { get; set; }

        public RelayCommand ShowLiveChartCommand { get; set; }

        private FSContext _Context;

        public HomeViewModel()
        {
            ShowLiveChartCommand = new RelayCommand(ShowLiveChart);

            _Context = new FSContext();

            var questions = _Context.Questions
                .ToList()
                .Select(q => new QuestionVM(q));
            Questions = new ObservableCollection<QuestionVM>(questions);
        }

        public void ShowLiveChart()
        {
            new LiveChartDemo().Show();
        }
    }
}