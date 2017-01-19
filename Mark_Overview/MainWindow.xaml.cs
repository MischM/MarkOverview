using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mark_Overview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Subject> Subjects = new List<Subject>();
        public List<Test> Tests = new List<Test>();
        public MainWindow()
        {
            InitializeComponent();
            CreateTestData();
            FillListView();
        }

        #region Methods
        private void CreateTestData()
        {
            //Subjects.Add(new Subject("Englisch", "En"));
            //Subjects.Add(new Subject("Deutsch", "De"));
            //Subjects.Add(new Subject("Mathi", "Ma"));
            //Subjects[0].Tests[0] = new Test("Test1", 5.5, 9, 10, 5.0, 1, new DateTime(2016, 11, 01));
            //Subjects[1].Tests.Add(new Test("Test2", 5.0, 8, 10, 5.0, 0.5, new DateTime(2016, 11, 15)));

            var en = new Subject("Englisch", "En");
            var de = new Subject("Deutsch", "De");
            var ma= new Subject("Mathi", "Ma");
            Subjects.Add(en);
            Subjects.Add(de);
            Subjects.Add(ma);
            Tests.Add(new Test(en, "Test1", 5.5, 9, 10, 5.0, 1, new DateTime(2016, 11, 01)));
            Tests.Add(new Test(en, "Test2", 5.0, 8, 10, 5.0, 0.5, new DateTime(2016, 11, 15)));
            Tests.Add(new Test(de, "Test2", 5.0, 8, 10, 5.0, 0.5, new DateTime(2016, 11, 15)));

        }

        public void FillListView()
        {
            // foreach (var subject in Subjects)
            //foreach (var test in subject.Tests)

            lsvOverview.ItemsSource = Tests;
            var view = (CollectionView)CollectionViewSource.GetDefaultView(lsvOverview.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("TestSubject.Description");
            view.GroupDescriptions.Add(groupDescription);

            
            //foreach (var subject in Subjects)
            //{
            //    foreach (var test in subject.Tests)
            //    { 
            //        lsvOverview.Items.Add(test);
            //    }
            //}
        }
    
    #endregion

    #region Events
    private void Image_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.M)
        {
            cat.Opacity = 100;
            cat.Focusable = false;
            cat.Cursor = Cursors.Arrow;
        }
    }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new SubjectWindow();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = new TestWindow(this);
            window.Show();
        }
    }
}
