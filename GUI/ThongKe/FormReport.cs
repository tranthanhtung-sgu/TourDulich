using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BUS;
using DAL.Entities;
using LiveCharts;
using LiveCharts.Wpf;

namespace GUI.ThongKe
{
    public partial class FormReport : Form
    {
        private BUS_Tour busTour = new BUS_Tour();
        private BUS_TouristGroup busTouristGroup = new BUS_TouristGroup();
        private List<TouristGroup> touristGroup = new List<TouristGroup>();
        private List<DAL.Entities.Tour> tours = new List<DAL.Entities.Tour>();
        public FormReport()
        {
            tours = busTour.GetAll();
            touristGroup = busTouristGroup.GetAll();
            InitializeComponent();
            this.Load += FormReport_Load;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {


            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Đoàn tham gia",
                    Values = new ChartValues<int> { 0,0,0,0,0,0,0,0,0,0,0,0 },
                    ScalesYAt = 0
                    
                },
                // new LineSeries
                // {
                //     Title = "Lợi nhuận tháng",
                //     Values = new ChartValues<float> { 0,0,0,0,0,0,0,0,0,0,0,0 },
                //     PointForeground = System.Windows.Media.Brushes.Yellow,
                //     ScalesYAt = 1
                // },
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Number of TouristGroup",
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            // //modifying the series collection will animate and update the chart
            // cartesianChart1.Series.Add(
            //     new LineSeries
            //     {
            //         Values = new ChartValues<double> { 5, 3, 2, 4, 5 },
            //         LineSmoothness = 0, //straight lines, 1 really smooth lines
            //         PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
            //         PointGeometrySize = 50,
            //         PointForeground = System.Windows.Media.Brushes.Gray
            //     }
            // );

            // //modifying any series values will also animate and update the chart
            // cartesianChart1.Series[2].Values.Add(5d);

            cbbTour.DataSource = tours;
            cbbTour.DisplayMember = "TenGoi";
            cbbTour.ValueMember = "TourId";
        }

        private void cbbTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tour = (DAL.Entities.Tour)cbbTour.SelectedItem;
            cartesianChart1.Series[0].Values.Clear();
            //cartesianChart1.Series[1].Values.Clear();
            for (int i = 1; i <= 12; i++)
            {
                //get number of touristgroup in i month match with tour 
                int count = 0;
                float revenue = 0;
                foreach (var item in touristGroup)
                {
                    if (item.TourId == tour.TourId && item.StartDate.Month == i)
                    {
                        count++;
                        revenue += item.Revenue;
                    }
                }
                //add to chart
                cartesianChart1.Series[0].Values.Add(count);
                //cartesianChart1.Series[1].Values.Add(revenue);
            }
            //get revenue of touristgroup in i month match with tour
        }
    }
}
