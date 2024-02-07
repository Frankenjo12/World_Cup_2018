using DAL.Model;
using DAL.Repo;
using DAL.Repo.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_App
{
    /// <summary>
    /// Interaction logic for TeamOverview.xaml
    /// </summary>
    public partial class TeamOverview : Window
    {
        private const string PATHCONFIG = @"../../../../DAL/WPFConfig/WPFConfig.txt";
        private const string PATHFAVTEAMMALE = @"../../../../DAL/FavoriteTeams/FavTeamMale.txt";
        private const string PATHFAVTEAMFEMALE = @"../../../../DAL/FavoriteTeams/FavTeamFemale.txt";
        private const string PATHFAVPLAYERSFEMALE = @"../../../../DAL/FavoritePlayers/FavPlayersFemale.txt";
        private const string PATHFAVPLAYERSMALE = @"../../../../DAL/FavoritePlayers/FavPlayersMale.txt";
        private const string PATHNOIMAGE = @"../../../../DAL/Images/NoImage.jpg";
        private const char DEL = '|';

        List<Team> teams = new List<Team>();
        List<Match> matches = new List<Match>();
        List<Player> favoritePlayers = new List<Player>();
        List<Player> enemyPlayers = new List<Player>();
        int playerImageSize = 0;

        IRepo repo;

        public TeamOverview()
        {
            InitializeComponent();
            InitRepo();
            InitializeScreenSize();
            LoadTeams();
            LoadMatches();
        }

        private Uri ParseRelativePath(string relativePath)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string absolutePath = System.IO.Path.Combine(baseDirectory, relativePath);

            return new Uri(absolutePath);
        }

        private void LoadPlayers()
        {
            if(cbFavorite.SelectedItem != null && cbEnemy.SelectedItem != null)
            {
                favoritePlayers.Clear();
                enemyPlayers.Clear();

                string[] parts = cbFavorite.SelectedItem.ToString().Split(DEL);
                string fav = parts[0];
                string[] parts2 = cbEnemy.SelectedItem.ToString().Split(DEL);
                string enemy = parts2[0];

                matches.ForEach(match =>
                {
                    if (match.HomeTeamCountry == fav)
                    {
                        if (match.AwayTeamCountry == enemy)
                        {
                            match.HomeTeamStatistics.StartingEleven.ForEach(p =>
                            {
                                Player player = new Player();
                                player.Name = p.Name;
                                player._Position = p.Position;
                                player.Number = p.ShirtNumber;
                                player.Captain = p.Captain;
                                player.Picture = GetFavPictureIfExists(player);
                                favoritePlayers.Add(player);
                                switch (p.Position.ToString()) 
                                {
                                    case "Goalie":
                                        SetGoalieFav(player);
                                        break;
                                    case "Defender":
                                        SetDefenderFav(player);
                                        break;
                                    case "Midfield":
                                        SetMidfieldFav(player);
                                        break;
                                    case "Forward":
                                        SetForwardFav(player);
                                        break;
                                }
                            });
                            match.AwayTeamStatistics.StartingEleven.ForEach(p =>
                            {
                                Player player = new Player();
                                player.Name = p.Name;
                                player._Position = p.Position;
                                player.Number = p.ShirtNumber;
                                player.Captain = p.Captain;
                                player.Picture = GetFavPictureIfExists(player);
                                enemyPlayers.Add(player);
                                switch (p.Position.ToString())
                                {
                                    case "Goalie":
                                        SetGoalieEnemy(player);
                                        break;
                                    case "Defender":
                                        SetDefenderEnemy(player);
                                        break;
                                    case "Midfield":
                                        SetMidfieldEnemy(player);
                                        break;
                                    case "Forward":
                                        SetForwardEnemy(player);
                                        break;
                                }
                            });
                        }
                    }
                    if (match.HomeTeamCountry == enemy)
                    {
                        if (match.AwayTeamCountry == fav)
                        {
                            match.AwayTeamStatistics.StartingEleven.ForEach(p =>
                            {
                                Player player = new Player();
                                player.Name = p.Name;
                                player._Position = p.Position;
                                player.Number = p.ShirtNumber;
                                player.Captain = p.Captain;
                                player.Picture = GetFavPictureIfExists(player);
                                favoritePlayers.Add(player);
                                switch (p.Position.ToString())
                                {
                                    case "Goalie":
                                        SetGoalieFav(player);
                                        break;
                                    case "Defender":
                                        SetDefenderFav(player);
                                        break;
                                    case "Midfield":
                                        SetMidfieldFav(player);
                                        break;
                                    case "Forward":
                                        SetForwardFav(player);
                                        break;
                                }
                            });
                            match.HomeTeamStatistics.StartingEleven.ForEach(p =>
                            {
                                Player player = new Player();
                                player.Name = p.Name;
                                player._Position = p.Position;
                                player.Number = p.ShirtNumber;
                                player.Captain = p.Captain;
                                player.Picture = GetFavPictureIfExists(player);
                                enemyPlayers.Add(player);
                                switch (p.Position.ToString())
                                {
                                    case "Goalie":
                                        SetGoalieEnemy(player);
                                        break;
                                    case "Defender":
                                        SetDefenderEnemy(player);
                                        break;
                                    case "Midfield":
                                        SetMidfieldEnemy(player);
                                        break;
                                    case "Forward":
                                        SetForwardEnemy(player);
                                        break;
                                }
                            });
                        }
                    }
                });
            }
        }

        private void SetForwardEnemy(Player player)
        {
            wpAttackersEnemy.Children.Add(CreateImage(player));
        }

        private void SetMidfieldEnemy(Player player)
        {
            wpMidfieldersEnemy.Children.Add(CreateImage(player));
        }

        private void SetDefenderEnemy(Player player)
        {
            wpDefendersEnemy.Children.Add(CreateImage(player));
        }

        private void SetGoalieEnemy(Player player)
        {
            imgGoalieEnemy.Source = new BitmapImage(ParseRelativePath(player.Picture));
            imgGoalieEnemy.Visibility = Visibility.Visible;
            imgGoalieEnemy.Tag = player;
            imgGoalieEnemy.Width = playerImageSize;
            imgGoalieEnemy.Height = playerImageSize;
            imgGoalieEnemy.MouseLeftButtonDown += (s, e) =>
            {
                OpenPlayerInfo(imgGoalieEnemy.Tag.ToString(), enemyPlayers);
            };
        }

        private void SetForwardFav(Player player)
        {
            wpAttackersFav.Children.Add(CreateImage(player));
        }

        private void SetMidfieldFav(Player player)
        {
            wpMidfieldersFav.Children.Add(CreateImage(player));
        }

        private UIElement CreateImage(Player player)
        {
            Image image = new Image();
            image.Width = playerImageSize;
            image.Height = playerImageSize;
            image.Source = new BitmapImage(ParseRelativePath(player.Picture));
            image.Tag = player; ;
            image.HorizontalAlignment= HorizontalAlignment.Center;
            image.HorizontalAlignment = HorizontalAlignment.Center;
            image.MouseLeftButtonDown += (s, e) =>
            {
                List<Player> allPlayers = new List<Player>();
                allPlayers.AddRange(favoritePlayers);
                allPlayers.AddRange(enemyPlayers);
                OpenPlayerInfo(image.Tag.ToString(), allPlayers);
            };

            return image;
        }

        private void SetDefenderFav(Player player)
        {
            wpDefendersFav.Children.Add(CreateImage(player));
        }

        private string GetFavPictureIfExists(Player player)
        {
            string image = "";

            if (Config.getGender() == "FEMALE")
            {
                if (File.Exists(PATHFAVPLAYERSFEMALE))
                {
                    string[] lines = File.ReadAllLines(PATHFAVPLAYERSFEMALE);
                    lines.ToList().ForEach(line =>
                    {
                        string[] parts = line.Split(DEL);
                        if (parts[0] == player.Name)
                        {
                            image = parts[2];
                        }
                    });
                }
            }
            else
            {
                if (File.Exists(PATHFAVPLAYERSMALE))
                {
                    string[] lines = File.ReadAllLines(PATHFAVPLAYERSMALE);
                    lines.ToList().ForEach(line =>
                    {
                        string[] parts = line.Split(DEL);
                        if (parts[0] == player.Name)
                        {
                            image = parts[2];
                        }
                    });
                }
            }

            if (!image.Equals(""))
            {
                return image;
            }

            return PATHNOIMAGE;
        }

        private void SetGoalieFav(Player p)
        {
            imgGoalieFav.Source = new BitmapImage(ParseRelativePath(p.Picture));
            imgGoalieFav.Visibility= Visibility.Visible;
            imgGoalieFav.Tag = p;
            imgGoalieFav.Width = playerImageSize;
            imgGoalieFav.Height = playerImageSize;
            imgGoalieFav.MouseLeftButtonDown += (s, e) =>
            {
                OpenPlayerInfo(imgGoalieFav.Tag.ToString(), favoritePlayers);
            };
        }

        private void OpenPlayerInfo(string tag, List<Player> favoritePlayers)
        {
            favoritePlayers.ForEach(p =>
            {
                if(p.ToString().Equals(tag))
                {
                    PlayerDetails details = new PlayerDetails(p);
                    OpenWindowWithAnimation(details);
                    return;
                }
            });
        }

        private void InitRepo()
        {
            repo = RepoFactory.GetRepo();
        }

        private void LoadTeams()
        {
            if(Config.getGender() == "FEMALE")
            {
                teams = repo.GetFemaleTeams().ToList();
                teams.ForEach(t =>
                {
                    cbFavorite.Items.Add(t);
                    cbEnemy.Items.Add(t);
                });
            }
            else
            {
                teams = repo.GetMaleTeams().ToList();
                teams.ForEach(t =>
                {
                    cbFavorite.Items.Add(t);
                    cbEnemy.Items.Add(t);
                });
            }

            HandleFavorite();
        }

        private void HandleFavorite()
        {
            if(Config.getGender() == "FEMALE")
            {
                if(!File.Exists(PATHFAVTEAMFEMALE))
                {
                    return;
                }
                string line = File.ReadAllText(PATHFAVTEAMFEMALE);
                foreach(var team in cbFavorite.Items)
                {
                    if (team.ToString().Equals(line))
                    {
                        cbFavorite.SelectedItem = team;
                        cbEnemy.Items.Remove(team);
                    }
                }
            }
            else
            {
                if (!File.Exists(PATHFAVTEAMMALE))
                {
                    return;
                }
                string line = File.ReadAllText(PATHFAVTEAMMALE);
                foreach (var team in cbFavorite.Items)
                {
                    if (team.ToString().Equals(line))
                    {
                        cbFavorite.SelectedItem = team;
                        cbEnemy.Items.Remove(team);
                    }
                }
            }
        }

        private void InitializeScreenSize()
        {
            string line = File.ReadAllText(PATHCONFIG);
            string[] parts = line.Split(DEL);

            string screenSize = parts[0];

            switch (screenSize) 
            {
                case "Fullscreen":
                    WindowState = WindowState.Maximized;
                    playerImageSize = 88;
                    break;
                case "Medium":
                    Height = 650;
                    Width = 1000;
                    playerImageSize = 68;
                    break;
                case "Low":
                    Height = 450;
                    Width = 800;
                    playerImageSize = 38;
                    break;
                default:
                    Height = 450;
                    Width = 800;
                    break;
            }
            wpDefendersFav.Width = playerImageSize;
            wpDefendersFav.Height = cvField.Height;
            wpDefendersEnemy.Width = playerImageSize;
            wpDefendersEnemy.Height = cvField.Height;
            wpMidfieldersFav.Width = playerImageSize;
            wpMidfieldersFav.Height = cvField.Height;
            wpMidfieldersEnemy.Width = playerImageSize;
            wpMidfieldersEnemy.Height = cvField.Height;
            wpAttackersFav.Width = playerImageSize;
            wpAttackersFav.Height = cvField.Height;
            wpAttackersEnemy.Width = playerImageSize;
            wpAttackersEnemy.Height = cvField.Height;
        }

        private void CheckCbChange(object sender, EventArgs e)
        {
            if(cbEnemy.SelectedItem != null && cbFavorite.SelectedItem != null)
            {
                CheckMatchups();
            }
        }

        private void CheckMatchups()
        {
            string[] parts = cbFavorite.SelectedItem.ToString().Split(DEL);
            string fav = parts[0];
            string[] parts2 = cbEnemy.SelectedItem.ToString().Split(DEL);
            string enemy = parts2[0];

            lbScore.Content = "Score";

            matches.ForEach(match =>
            {
                if(match.HomeTeamCountry == fav)
                {
                    if(match.AwayTeamCountry == enemy)
                    {
                        long favScore = match.HomeTeam.Goals;
                        long enemyScore = match.AwayTeam.Goals;
                        lbScore.Content = favScore.ToString() + " : " + enemyScore.ToString();
                    }
                }
                if (match.HomeTeamCountry == enemy)
                {
                    if (match.AwayTeamCountry == fav)
                    {
                        long enemyScore = match.HomeTeam.Goals;
                        long favScore = match.AwayTeam.Goals;
                        lbScore.Content = favScore.ToString() + " : " + enemyScore.ToString();
                    }
                }
            });

            if(lbScore.Content.ToString().Equals("Score"))
            {
                ClearPlayers();
                MessageBox.Show("These teams didn't play against each other", "Teams not matched");
            }
            else
            {
                ClearPlayers();
                LoadPlayers();
            }
        }

        private void ClearPlayers()
        {
            imgGoalieFav.Visibility = Visibility.Hidden;
            imgGoalieEnemy.Visibility = Visibility.Hidden;
            wpDefendersFav.Children.Clear();
            wpDefendersEnemy.Children.Clear();
            wpMidfieldersFav.Children.Clear();
            wpMidfieldersEnemy.Children.Clear();
            wpAttackersFav.Children.Clear();
            wpAttackersEnemy.Children.Clear();
        }

        private void LoadMatches()
        {
            if(Config.getGender() == "FEMALE")
            {
                matches = repo.GetFemaleMatches().ToList();
            }
            else
            {
                matches = repo.GetMaleMatches().ToList();
            }
        }

        private void btnFavorite_Click(object sender, RoutedEventArgs e)
        {
            Team teamToSend = new Team();
            teams.ForEach(team =>
            {
                if (cbFavorite.SelectedItem != null && team.ToString() == cbFavorite.SelectedItem.ToString())
                {
                    teamToSend = team;
                    TeamDetails details = new TeamDetails(teamToSend);
                    OpenWindowWithAnimation(details);
                }
            });
        }

        private void OpenWindowWithAnimation(Window details)
        {
            var animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = TimeSpan.FromSeconds(0.5);

            Storyboard.SetTarget(animation, details);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Window.OpacityProperty));

            var storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Begin();

            details.Show();
        }

        private void btnEnemy_Click(object sender, RoutedEventArgs e)
        {
            Team teamToSend = new Team();
            teams.ForEach(team =>
            {
                if (cbEnemy.SelectedItem != null &&  team.ToString() == cbEnemy.SelectedItem.ToString())
                {
                    teamToSend = team;
                    TeamDetails details = new TeamDetails(teamToSend);
                    OpenWindowWithAnimation(details);
                }
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow settings = new MainWindow();
            OpenWindowWithAnimation(settings);
        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
