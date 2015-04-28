namespace Portfolio.ViewModels
{
    using System.Collections.Generic;

    using DotNet.Highcharts;

    public class HomeIndexViewModel
    {
        public Highcharts TechnicalCompetencesChart { get; set; }
        public Highcharts HumanCompetencesChart { get; set; }

        public HomeIndexViewModel(Highcharts humanChart, Highcharts techChart)
        {
            this.HumanCompetencesChart = humanChart;
            this.TechnicalCompetencesChart = techChart;
        }
    }
}