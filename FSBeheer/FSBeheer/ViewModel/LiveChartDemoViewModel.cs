using FSBeheer.Model;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FSBeheer.ViewModel
{
    public class LiveChartDemoViewModel : BaseViewModel
    {
        public PieChart PieChart { get; set; }
        public CartesianChart BarChart { get; set; }

        public ObservableCollection<AnswerVM> Options { get; set; }
        public ObservableCollection<AnswerVM> Answers { get; set; }

        public List<string> Labels { get; set; }

        public LiveChartDemoViewModel(QuestionVM SelectedQuestion, string ChartType)
        {
            _Context = new FSContext();

            var answers = _Context.Answers
                .ToList()
                .Where(a => a.QuestionId == SelectedQuestion.Id)
                .Select(a => new AnswerVM(a));
            Answers = new ObservableCollection<AnswerVM>(answers);

            var options = SelectedQuestion.Options.ToString();
            var optionsArr = options.Split(';');
            Options = new ObservableCollection<AnswerVM>();
            foreach (string s in optionsArr)
            {
                Options.Add(new AnswerVM(new Answer { Content = s }));
            }

            if (ChartType == "Pie")
            {
                PieChart = new PieChart();

                foreach (AnswerVM option in Options)
                {
                    //Determine how often this answer was given
                    int count = Answers.Where(a => a.Content == option.Content).Count();

                    if (count != 0)
                    {
                        PieChart.Series.Add(new PieSeries
                        {
                            Values = new ChartValues<int> { count },
                            DataLabels = true,
                            LabelPoint = chartpoint => string.Format("Antw. {0}, {1}x ({2:p})", option.OptionIndex, chartpoint.Y, chartpoint.Participation)
                        });
                    }
                }
            }
            else
            {
                BarChart = new CartesianChart();

                BarChart.AxisY.Add(new Axis
                {
                    Title = "Aantal keer gegeven",
                    MinValue = 0,
                    MaxValue = Options.Count,
                    Separator = new Separator
                    {
                        Step = 1
                    }
                });
                BarChart.AxisX.Add(new Axis
                {
                    Title = "Opties",
                    ShowLabels = false
                });

                foreach (AnswerVM option in Options)
                {
                    //Determine how often this answer was given
                    int count = Answers.Where(a => a.Content == option.Content).Count();

                    if (count != 0)
                    {
                        BarChart.Series.Add(new ColumnSeries
                        {
                            Values = new ChartValues<int> { count },
                            DataLabels = true,
                            LabelPoint = point => string.Format("{0}: {1}x", option.OptionIndex, point.Y)
                        });
                    }
                }
            }
        }
    }
}
