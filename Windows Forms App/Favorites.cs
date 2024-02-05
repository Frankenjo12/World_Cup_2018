using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Model;
using DAL.Repo;
using DAL.Repo.Config;

namespace Windows_Forms_App
{
    public partial class Favorite_National_Team : Form
    {
        private const string PATHFAVTEAMMALE = @"../../../../DAL/FavoriteTeams/FavTeamMale.txt";
        private const string PATHFAVPLAYERSMALE = @"../../../../DAL/FavoritePlayers/FavPlayersMale.txt";
        private const string PATHFAVTEAMFEMALE = @"../../../../DAL/FavoriteTeams/FavTeamFemale.txt";
        private const string PATHFAVPLAYERSFEMALE = @"../../../../DAL/FavoritePlayers/FavPlayersFemale.txt";
        private const string PATHNOIMAGE = @"../../../../DAL/Images/NoImage.png";

        private PictureBox noImage = null;
        private IList<Player> players = new List<Player>();
        private IList<Match> matches = new List<Match>();
        private IList<Player> favoritePlayers = new List<Player>();
        private string selectedPlayer = null;

        private const char DEL = '|';

        public Favorite_National_Team()
        {
            InitializeComponent();
            LoadTeams();
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            IRepo repo = RepoFactory.GetRepo();
            if (Config.getGender() == "FEMALE")
            {
                matches = repo.GetFemaleMatches();
            }
            else
            {
                matches = repo.GetMaleMatches();
            }

            IList<Team> teams = new List<Team>();

            matches.ToList().ForEach(match =>
            {
                if(!teams.Contains(match.HomeTeam))
                {
                    match.HomeTeamStatistics.StartingEleven.ForEach(p =>
                    {
                        Player player = new Player();
                        player.Name = p.Name;
                        player.Number = p.ShirtNumber;
                        player.Captain = p.Captain;
                        player._Position = p.Position;
                        player.Picture = PATHNOIMAGE;
                        players.Add(player);
                    });

                    teams.Add(match.HomeTeam);
                }
                else if (!teams.Contains(match.AwayTeam))
                {
                    match.AwayTeamStatistics.StartingEleven.ForEach(p =>
                    {
                        Player player = new Player();
                        player.Name = p.Name;
                        player.Number = p.ShirtNumber;
                        player.Captain = p.Captain;
                        player._Position = p.Position;
                        player.Picture = PATHNOIMAGE;
                        players.Add(player);
                    });

                    teams.Add(match.AwayTeam);
                }
            });

            //noImage = CreatePictureBorder();

            players.ToList().ForEach((player) =>
            {
                ShowPlayer(player);
            });
        }

        private void ShowPlayer(Player player)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.BackColor = Color.White;
            panel.Width = 380;
            panel.Height = 150;
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Controls.Add(CreatePlayerData(player));
            panel.Tag = player.ToString();
            panel.MouseClick += (s, e) =>
            {
                if(e.Button == MouseButtons.Right)
                {
                    Point point = new Point(e.X, e.Y);
                    ctxMSRegular.Show(point);
                    selectedPlayer = (s as Control).Tag.ToString(); 
                }
            };

            if (IsPlayerFavorite(player))
            {                
                //panel.Controls.Add(noImage);
                flpRight.Controls.Add(panel);
            }
            else
            {
                flpLeft.Controls.Add(panel);
            }
        }

        private bool IsPlayerFavorite(Player player)
        {
            bool isFavorite = false;

            if (Config.getGender() == "FEMALE")
            {
                if (!File.Exists(PATHFAVPLAYERSFEMALE))
                {
                    return isFavorite;
                }
                string[] lines = File.ReadAllLines(PATHFAVPLAYERSFEMALE);
                lines.ToList().ForEach(line =>
                {
                    string[] parts = line.Split(DEL);
                    if (player.ToString() == line)
                    {
                        favoritePlayers.Add(player);
                        isFavorite= true;
                    }
                });
            }
            else
            {
                if (!File.Exists(PATHFAVPLAYERSMALE))
                {
                    return isFavorite;
                }
                string[] lines = File.ReadAllLines(PATHFAVPLAYERSMALE);
                lines.ToList().ForEach(line =>
                {
                    if (player.ToString() == line)
                    {
                        favoritePlayers.Add(player);
                        isFavorite = true;
                    }
                });
            }

            if (favoritePlayers.Contains(player))
            {
                isFavorite = true;
            }

            return isFavorite;
        }

        private TextBox CreatePlayerData(Player player)
        {
            TextBox textBox = new TextBox();
            textBox.Width = 250;
            textBox.Height = 145;
            textBox.Multiline = true;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Text = player.Name + " " + player.Number
                + Environment.NewLine + player._Position
                + Environment.NewLine + "Captain: " + player.Captain;

            return textBox;
        }

        private PictureBox CreatePictureBorder()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            pictureBox.Image = Image.FromFile(PATHNOIMAGE);

            return pictureBox;
        }

        private void LoadTeams()
        {
            IRepo repo = RepoFactory.GetRepo();
            IList<Team> teams = new List<Team>();
            Team favoriteTeam = new Team();
            if (Config.getGender() == "FEMALE")
            {
                teams = repo.GetFemaleTeams();
                if(File.Exists(PATHFAVTEAMFEMALE))
                {
                    string[] lines = File.ReadAllLines(PATHFAVTEAMFEMALE);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(DEL);
                        favoriteTeam.Country = parts[0];
                        favoriteTeam.FifaCode = parts[1];
                    }
                }
            }
            else
            {
                teams = repo.GetMaleTeams();
                if (File.Exists(PATHFAVTEAMMALE))
                {
                    string[] lines = File.ReadAllLines(PATHFAVTEAMMALE);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(DEL);
                        favoriteTeam.Country = parts[0];
                        favoriteTeam.FifaCode = parts[1];
                    }
                }
            }

            teams.ToList().ForEach(team => cbTeams.Items.Add(team));

            foreach(object i in cbTeams.Items)
            {
                if(i.ToString().Equals(favoriteTeam.ToString()))
                {
                    cbTeams.SelectedIndex = cbTeams.Items.IndexOf(i);
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            HandleFavTeam();
        }

        private void HandleFavTeam()
        {
            string? favteam = cbTeams.SelectedItem.ToString();
            if (favteam != null)
            {
                if (Config.getGender() == "FEMALE")
                {
                    if (!File.Exists(PATHFAVTEAMFEMALE))
                    {
                        File.Create(PATHFAVTEAMFEMALE);
                    }
                    File.WriteAllText(PATHFAVTEAMFEMALE, favteam);
                }
                else
                {
                    if (!File.Exists(PATHFAVTEAMMALE))
                    {
                        File.Create(PATHFAVTEAMMALE);
                    }
                    File.WriteAllText(PATHFAVTEAMMALE, favteam);
                }
            }
        }

        private void tSMIAddFavorite_Click(object sender, EventArgs e)
        {
            Player playerToTransfer = new Player();
            players.ToList().ForEach(player =>
            {
                if(player.ToString().Equals(selectedPlayer))
                {
                    playerToTransfer = player;
                }
            });

            favoritePlayers.Add(playerToTransfer);
            SavePlayerToFile(playerToTransfer);

            RefreshPlayers(playerToTransfer);
        }

        private void RefreshPlayers(Player playerToTransfer)
        {
            foreach(FlowLayoutPanel p in flpLeft.Controls)
            {
                if (p.Tag.ToString().Equals(playerToTransfer.ToString()))
                {
                    flpLeft.Controls.Remove(p);
                    flpRight.Controls.Add(p);
                    break;
                }
            }
        }

        private void SavePlayerToFile(Player playerToTransfer)
        {
            if(Config.getGender() == "FEMALE")
            {
                if(!File.Exists(PATHFAVPLAYERSFEMALE))
                {
                    File.Create(PATHFAVPLAYERSFEMALE);
                }
                File.AppendAllText(PATHFAVPLAYERSFEMALE, playerToTransfer.ToString());
            }
            else
            {
                if (!File.Exists(PATHFAVPLAYERSMALE))
                {
                    File.Create(PATHFAVPLAYERSMALE);
                }
                File.AppendAllText(PATHFAVPLAYERSMALE, playerToTransfer.ToString() + "\n");
            }
        }
    }
}
