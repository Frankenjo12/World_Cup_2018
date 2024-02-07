using DAL.Model;
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
using System.Windows.Shapes;

namespace Wpf_App
{
    /// <summary>
    /// Interaction logic for TeamDetails.xaml
    /// </summary>
    public partial class PlayerDetails : Window
    {
        private Player player = new Player();

        public PlayerDetails(Player p)
        {
            player = p;
            InitializeComponent();
            LoadPlayerData();
        }

        private void LoadPlayerData()
        {
            lbName.Content = player.Name;
            lbNumber.Content = player.Number;
            lbCaptain.Content = player.Captain.ToString();
            lbPosition.Content = player._Position;
            imgPlayer.Source = new BitmapImage(ParseRelativePath(player.Picture));
        }

        private Uri ParseRelativePath(string relativePath)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string absolutePath = System.IO.Path.Combine(baseDirectory, relativePath);

            return new Uri(absolutePath);
        }
    }
}
