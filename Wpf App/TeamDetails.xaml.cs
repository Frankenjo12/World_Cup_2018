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
    public partial class TeamDetails : Window
    {
        private Team team = new Team();

        public TeamDetails(Team team)
        {
            this.team = team;
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            lbName.Content = team.Country;
            lbCode.Content = team.FifaCode;
            lbPlayed.Content = team.GamesPlayed.ToString();
            lbWins.Content = team.Wins.ToString();
            lbLoss.Content = team.Losses.ToString();
            lbDraw.Content = team.Draws.ToString();
            lbScored.Content = team.GoalsFor.ToString();
            lbConceived.Content = team.GoalsAgainst.ToString();
            lbDifference.Content = team.GoalDifferential.ToString();
        }
    }
}
