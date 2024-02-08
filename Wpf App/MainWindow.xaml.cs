using DAL.Repo.Config;
using DAL.WPFConfig;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Wpf_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string PATHCONFIG = @"../../../../DAL/WPFConfig/WPFConfig.txt";
        private const char DEL = '|';

        private List<String> screenSizes = new List<String>();

        public MainWindow()
        {
            CheckConfigExists();
            InitializeComponent();
            SetLanguage();
            LoadScreenSizes();
        }

        private void SetLanguage()
        {
            string lang = "";
            if(CheckLanguage().Equals("Croatian"))
            {
                lang = "hr";
                
            }
            else
            {
                lang = "en-US";
            }

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            Application.Current.Resources.MergedDictionaries.Clear();
            ResourceDictionary rsdict = new ResourceDictionary()
            {
                Source = new Uri($"/Dictionary-{lang}.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Add(rsdict);
        }

        private string CheckLanguage()
        {
            if(File.Exists(PATHCONFIG))
            {
                string line = File.ReadAllText(PATHCONFIG);
                string[] parts = line.Split(DEL);
                return parts[1];
            }
            return "English";
        }

        private void CheckConfigExists()
        {
            if(File.Exists(PATHCONFIG))
            {
                if(WpfInitial.isInitial)
                {
                    WpfInitial.isInitial = false;
                    this.Hide();
                    TeamOverview overview = new TeamOverview();
                    overview.Show();
                }
            }
        }

        private void LoadScreenSizes()
        {
            screenSizes.Add("Fullscreen");
            screenSizes.Add("Medium");
            screenSizes.Add("Low");

            screenSizes.ForEach(s => cbScreen.Items.Add(s));
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            string fileLine = "";

            if(cbScreen.SelectedItem == null)
            {
                fileLine += "Medium" + DEL;
            }
            else
            {
                fileLine += cbScreen.SelectedItem.ToString() + DEL;
            }

            if (rbCroatian.IsChecked == false && rbEnglish.IsChecked == false)
            {
                fileLine += "English" + DEL;
            }
            else if(rbEnglish.IsChecked == true)
            {
                fileLine += "English";
            }
            else if (rbCroatian.IsChecked == true)
            {
                fileLine += "Croatian";
            }

            File.WriteAllText(PATHCONFIG, fileLine);

            SetLanguage();

            this.Hide();
            TeamOverview overview = new TeamOverview();
            overview.Show();
        }
    }
}
