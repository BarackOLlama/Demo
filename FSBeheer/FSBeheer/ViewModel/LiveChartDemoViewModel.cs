using GalaSoft.MvvmLight;
using LiveCharts;
using LiveCharts.Wpf;

namespace FSBeheer.ViewModel
{
    public class LiveChartDemoViewModel : ViewModelBase
    {
        public PieChart PieChart { get; set; }
        public CartesianChart BarChart { get; set; }

        public LiveChartDemoViewModel(QuestionVM SelectedQuestion, string ChartType)
        {
            if(ChartType == "Pie")
            {
                PieChart = new PieChart();

                //foreach(string s in array)
                //{
                //    PieChart.Series.Add(new PieSeries
                //    {
                //        Values = new ChartValues<string> { s },
                //        DataLabels = true,
                //        LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
                //    });
                //}
            }
            else
            {

            }
        }
    }
}
