using FSBeheer.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Linq;

namespace FSBeheer.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<QuestionVM> Questions { get; set; }

        public QuestionVM SelectedQuestion { get; set; }
        public string ChartType { get; set; }

        public RelayCommand ShowPieChartCommand { get; set; }
        public RelayCommand ShowBarChartCommand { get; set; }
        public RelayCommand CanExecuteChangedCommand { get; set; }

        public HomeViewModel()
        {
            ShowPieChartCommand = new RelayCommand(ShowPieChart, CanExecute);
            ShowBarChartCommand = new RelayCommand(ShowBarChart, CanExecute);
            CanExecuteChangedCommand = new RelayCommand(CanExecuteChanged);

            _Context = new FSContext();

            var questions = _Context.Questions.ToList().Select(q => new QuestionVM(q));
            Questions = new ObservableCollection<QuestionVM>(questions);
        }

        public void ShowPieChart()
        {
            ChartType = "Pie";
            new LiveChartDemo().Show();
        }

        public void ShowBarChart()
        {
            ChartType = "Bar";
            new LiveChartDemo().Show();
        }

        public bool CanExecute()
        {
            return SelectedQuestion != null;
        }

        public void CanExecuteChanged()
        {
            ShowPieChartCommand.RaiseCanExecuteChanged();
            ShowBarChartCommand.RaiseCanExecuteChanged();
        }
    }
}