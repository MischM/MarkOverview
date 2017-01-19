using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mark_Overview
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow(MainWindow main)
        {
            InitializeComponent();
            cmbSub.ItemsSource = main.Subjects;
            //foreach (var sub in Subs)
            //{
            //    cmbSub.Items.Add(sub.Description);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSub.SelectedIndex == -1)
            {
                MessageBox.Show("Wähle ein Fach", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtTopic.Text))
            {
                MessageBox.Show("Gib ein Thema ein", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (dtp.SelectedDate == null)
            {
                MessageBox.Show("Es muss ein Datum ausgewählt sein", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (!Regex.IsMatch(txtMark.Text, @"[1-6](.[0-9]{0,2})?") && !String.IsNullOrEmpty(txtMark.Text))
            {
                MessageBox.Show("Note muss im folgendem Format sein: 5.0 ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(txtPoints.Text, @"\d{1,}\.\d") && !String.IsNullOrEmpty(txtPoints.Text))
            {
                MessageBox.Show("Punkte müssen im folgendem Format sein: 23 oder 22.5", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(txtMaxPoints.Text, @"\d{1,}") && !String.IsNullOrEmpty(txtMaxPoints.Text))
            {
                MessageBox.Show("Punkte müssen im folgendem Format sein: 23", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //otdo: Avg & weighting

            CreateTest();
        }

        private void CreateTest()
        {
            var test = new Test(cmbSub.SelectedItem.ToString(),
                                Convert.ToDouble(txtTopic.Text),
                                Convert.ToDouble(txtPoints.Text),
                                Convert.ToInt32(txtMaxPoints.Text),
                                Convert.ToDouble(txtAvg.Text),
                                Convert.ToDouble(txtWeighting.Text),
                                DateTime.ParseExact(dtp.SelectedDate.Value.ToString(), "dd.MM.yyyy", new CultureInfo("de-DE")));
            //this.Close();
        }
    }
}
