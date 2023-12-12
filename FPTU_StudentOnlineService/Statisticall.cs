using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FTU_StudentOnlineService
{
    public partial class Statisticall : Form
    {
        public Statisticall()
        {
            InitializeComponent();
        }

        //private void LoadColumnStatisticalNormal()
        //{
        //    // Assuming your DataGridView is named table_scList
        //    table_statisticalnormal.ColumnCount = 3;
        //    table_statisticalnormal.Columns[0].Name = "Quantity";
        //    table_statisticalnormal.Columns[1].Name = "RegistrationDate";
        //    table_statisticalnormal.Columns[2].Name = "Description";
        //}
        private void LoadColumnStatisticalSum()
        {
            // Assuming your DataGridView is named table_scList
            table_statisticalSum.ColumnCount = 4;
            table_statisticalSum.Columns[0].Name = "Month";
            table_statisticalSum.Columns[1].Name = "Information Change Service";
            table_statisticalSum.Columns[2].Name = "Tuition Reduction Service";
            table_statisticalSum.Columns[3].Name = "Student Confirmation Service";
        }

        //private void LoadDataStatisticalNormal()
        //{
        //    // Assuming your DataGridView is named table_scList
        //    table_statisticalnormal.Rows.Clear();
        //    StatisticalDAO statisticalDAO = new StatisticalDAO();
        //    List<Statistical> statisticals = statisticalDAO.GetStatisticals();

        //    foreach (Statistical s in statisticals)
        //    {
        //        string[] row = {
        //        s.QuantityProperty.ToString(),
        //        s.RegistrationDateProperty.ToString(),
        //        s.ServiceTypeDescriptionProperty.ToString()
        //    };
        //        table_statisticalnormal.Rows.Add(row);
        //    }
        //}
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox có giá trị là 10
          
        }
        private void DrawPieChart(List<Statistical> data)
        {
            pchart_statistical.Series.Clear();

            Series quantitySeries = new Series("Quantity");
            quantitySeries.ChartType = SeriesChartType.Pie;

            double studentConfirmationSeries = 0;
            double tuitionReductionSeries = 0;
            double informationChangeSeries = 0;

            foreach (var item in data)
            {
                studentConfirmationSeries += Convert.ToDouble(item.StudentConfirmationServiceProperty);
                tuitionReductionSeries += Convert.ToDouble(item.TuitionReductionServiceProperty);
                informationChangeSeries += Convert.ToDouble(item.InformationChangeServiceProperty);
            }

            // Thêm dữ liệu vào Series
            quantitySeries.Points.AddXY("StudentConfirmation", studentConfirmationSeries);
            quantitySeries.Points.AddXY("TuitionReduction", tuitionReductionSeries);
            quantitySeries.Points.AddXY("InformationChange", informationChangeSeries);

            // Thêm Series vào Pie Chart
            pchart_statistical.Series.Add(quantitySeries);
        }

        private void LoadDataStatisticalSum()
        {
            // Assuming your DataGridView is named table_scList
            table_statisticalSum.Rows.Clear();
            StatisticalDAO statisticalDAO = new StatisticalDAO();
            List<Statistical> statisticals = statisticalDAO.GetStatisticalsSum();

            foreach (Statistical s in statisticals)
            {
                string[] row = {
                s.MonthProperty.ToString(),
                s.InformationChangeServiceProperty.ToString(),
                s.TuitionReductionServiceProperty.ToString(),
                s.StudentConfirmationServiceProperty.ToString()
            };
                table_statisticalSum.Rows.Add(row);
            }
        }

        private void PopulateMonthsComboBox()
        {
            // Clear existing items
            cbb_month.Items.Clear();

            // Add 12 months to the ComboBox
            for (int i = 1; i <= 12; i++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                cbb_month.Items.Add(monthName);
            }
            cbb_month.SelectedIndex = 0;
        }

        private void Statisticall_Load(object sender, EventArgs e)
        {
            PopulateMonthsComboBox();
            //LoadColumnStatisticalNormal();
            //LoadDataStatisticalNormal();
            LoadColumnStatisticalSum();
            LoadDataStatisticalSum();
        }

        private void cbb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatisticalDAO statisticalDAO = new StatisticalDAO();
            List<Statistical> statisticals1 = statisticalDAO.GetStatisticalsSum();
            List<Statistical> statisticals = statisticals1.Where(s => s.MonthProperty == cbb_month.Text).ToList();
            DrawPieChart(statisticals);
        }
    }
}
