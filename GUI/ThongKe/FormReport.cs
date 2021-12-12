using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private DAL.Entities.Tour tour = null;
        public FormReport()
        {
            tours = busTour.GetAll();
            touristGroup = busTouristGroup.GetAll();
            InitializeComponent();
            this.Load += FormReport_Load;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            cbbTour.DataSource = tours;
            cbbTour.DisplayMember = "TenGoi";
            cbbTour.ValueMember = "TourId";

            // cartesianChart1.Series.Add(new LineSeries
            // {
            //     Title = "Đoàn tham gia",
            //     Values = new ChartValues<int> {0,0,0,0,0,0,0,0,0,0,0,0},
            //     PointForeground = System.Windows.Media.Brushes.Blue,
            //     Foreground = System.Windows.Media.Brushes.Blue,
            //     Stroke = System.Windows.Media.Brushes.Blue,
            //     Fill = System.Windows.Media.Brushes.Transparent
            // });

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                Separator = new Separator
                {
                    Step = 1,
                },
                FontSize = 14,
            });
  
            // cartesianChart1.AxisY.Add(new Axis
            // {
            //     Title = "Đoàn",
            //     Foreground = System.Windows.Media.Brushes.DodgerBlue,
            //     Separator = new Separator
            //     {
            //         Step = 1,
            //         Stroke = System.Windows.Media.Brushes.DodgerBlue,
            //         StrokeThickness = 1
            //     }
            // });

            // DAL.Entities.Tour tour = tours[0];
            // List<int> doan = new List<int>();
            // for (int i = 1; i <= 12; i++)
            // {
            //     //get number of touristgroup in i month match with tour 
            //     int countDoan = 0;
            //     foreach (var item in touristGroup)
            //     {
            //         if (item.TourId == tour.TourId && item.StartDate.Month == i)
            //         {
            //             countDoan++;
            //         }
            //     }
            //     doan.Add(countDoan);
            // }
            // cartesianChart1.Series[0].Values = new ChartValues<int>(doan);
            cartesianChart1.LegendLocation = LegendLocation.Right;  
        }

        private void cbbTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            tour = (DAL.Entities.Tour)cbbTour.SelectedItem;
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisY.Clear();

            List<int> doan = new List<int>();
            List<int> customers = new List<int>();
            List<float> revenue = new List<float>();

            for (int i = 1; i <= 12; i++)
            {
                int countDoan = 0;
                int countCustomer = 0;
                float revenueMonth = 0;
                foreach (var item in touristGroup)
                {
                    if (item.TourId == tour.TourId && item.StartDate.Month == i)
                    {
                        countDoan++;
                        countCustomer += item.TouristGroup_Customers.Count;
                        revenueMonth += item.Revenue;
                    }
                }
                doan.Add(countDoan);
                customers.Add(countCustomer);
                revenue.Add(revenueMonth);
            }

            TouristGroupLine = new LineSeries
            {
                Title = "Đoàn tham gia",
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Values = new ChartValues<int>(doan),
                ScalesYAt = 0
            };

            CustomerLine = new LineSeries
            {
                Title = "Khách hàng",
                Foreground = System.Windows.Media.Brushes.Red,
                Values = new ChartValues<int>(customers),
                ScalesYAt = 1
            };

            RevenueLine = new LineSeries
            {
                Title = "Doanh thu",
                Foreground = System.Windows.Media.Brushes.Green,
                Values = new ChartValues<float>(revenue),
                ScalesYAt = 2
            };

            cartesianChart1.Series = new SeriesCollection
            {
                TouristGroupLine,
                CustomerLine,
                RevenueLine
            };

            TouristGroupAxis = new Axis
            {
                Foreground = System.Windows.Media.Brushes.DodgerBlue,
                Separator = new Separator
                {
                    Step = 1,
                },
                Position = AxisPosition.RightTop

            };

            CustomerAxis = new Axis
            {
                Foreground = System.Windows.Media.Brushes.Red,
                Separator = new Separator
                {
                    Step = 1,
                },
                Position = AxisPosition.RightTop
            };

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"

            RevenueAxis = new Axis
            {
                Foreground = System.Windows.Media.Brushes.Green,
                Separator = new Separator
                {
                    Step = 5000000,
                },
                LabelFormatter = val => val.ToString("C0", cul.NumberFormat)
            };

            cartesianChart1.AxisY = new AxesCollection
            {
                TouristGroupAxis,
                CustomerAxis,
                RevenueAxis
            };

            cboxKhach.Checked = false;
            cboxDoan.Checked = false;
            cboxLoiNhuan.Checked = false;
            
            // hide all series and show only one TouristGroupLine
            TouristGroupLine.Visibility = Visibility.Hidden;
            CustomerLine.Visibility = Visibility.Hidden;
            RevenueLine.Visibility = Visibility.Hidden;
            TouristGroupAxis.Visibility = Visibility.Hidden;
            CustomerAxis.Visibility = Visibility.Hidden;
            RevenueAxis.Visibility = Visibility.Hidden;

        }

        private void cboxDoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDoan.Checked)
            {
                TouristGroupLine.Visibility = Visibility.Visible;
                TouristGroupAxis.Visibility = Visibility.Visible;
            }
            else
            {
                TouristGroupLine.Visibility = Visibility.Hidden;
                TouristGroupAxis.Visibility = Visibility.Hidden;
            }
        }

        private void cboxKhach_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxKhach.Checked)
            {
                CustomerLine.Visibility = Visibility.Visible;
                CustomerAxis.Visibility = Visibility.Visible;
            }
            else
            {
                CustomerLine.Visibility = Visibility.Hidden;
                CustomerAxis.Visibility = Visibility.Hidden;
            }
        }

        private void cboxLoiNhuan_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxLoiNhuan.Checked)
            {
                RevenueLine.Visibility = Visibility.Visible;
                RevenueAxis.Visibility = Visibility.Visible;
            }
            else
            {
                RevenueLine.Visibility = Visibility.Hidden;
                RevenueAxis.Visibility = Visibility.Hidden;
            }
        }

        public LineSeries TouristGroupLine { get; set; }
        public LineSeries CustomerLine { get; set; }
        public LineSeries RevenueLine { get; set; }
        public Axis TouristGroupAxis { get; set; }
        public Axis CustomerAxis { get; set; }
        public Axis RevenueAxis { get; set; }
    }
}
