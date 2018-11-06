using GalaSoft.MvvmLight;
using LiveCharts;
using LiveCharts.Wpf;

namespace FSBeheer.ViewModel
{
    public class LiveChartDemoViewModel : ViewModelBase
    {
        public SeriesCollection SeriesCollection { get; set; }

        public LiveChartDemoViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Values = new ChartValues<decimal>{ 5 },
                    DataLabels = true,
                    LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
        },
                new PieSeries
                {
                    Values = new ChartValues<decimal>{ 5 },
                    DataLabels = true,
                    LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
                }
            };
        }
    }
}
