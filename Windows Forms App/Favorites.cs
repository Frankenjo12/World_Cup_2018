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
using Windows_Forms_App.Utils;

namespace Windows_Forms_App
{
    public partial class Favorite_National_Team : Form
    {
        private const string PATHFAVTEAMMALE = @"../../../../DAL/FavoriteTeams/FavTeamMale.txt";
        private const string PATHFAVPLAYERSMALE = @"../../../../DAL/FavoritePlayers/FavPlayersMale.txt";
        private const string PATHFAVTEAMFEMALE = @"../../../../DAL/FavoriteTeams/FavTeamFemale.txt";
        private const string PATHFAVPLAYERSFEMALE = @"../../../../DAL/FavoritePlayers/FavPlayersFemale.txt";
        private const string PATHNOIMAGE = @"../../../../DAL/Images/NoImage.jpg";
        private const string PATHIMAGES = @"../../../../DAL/Images/";

        private ISet<Player> players = new HashSet<Player>();
        private IList<Match> matches = new List<Match>();
        private IList<Player> favoritePlayers = new List<Player>();
        private string selectedPlayer = "";
        private string selectedFavoritePlayer = "";

        private const char DEL = '|';

        public Favorite_National_Team()
        {
            InitializeComponent();
            LoadTeams();
            LoadPlayers();
            ImageUtils.SetImage(pbPlayer, PATHNOIMAGE);
        }

        private void LoadPlayers()
        {
            selectedFavoritePlayer = "";
            selectedPlayer = "";

            IRepo repo = RepoFactory.GetRepo();
            if (Config.getGender() == "FEMALE")
            {
                if (!File.Exists(PATHFAVTEAMFEMALE)) return;
                matches = repo.GetFemaleMatches();

                string[] lines = File.ReadAllLines(PATHFAVTEAMFEMALE);
                lines.ToList().ForEach(line =>
                {
                    string[] parts = line.Split(DEL);
                    matches.ToList().ForEach(match =>
                    {
                        if (match.HomeTeam.Country == parts[0])
                        {
                            match.HomeTeamStatistics.StartingEleven.ForEach(info =>
                            {
                                Player p = new Player();
                                p.Name = info.Name;
                                p.Number = info.ShirtNumber;
                                p._Position = info.Position;
                                p.Captain = info.Captain;
                                p.Picture = PATHNOIMAGE;

                                if (File.Exists(PATHFAVPLAYERSFEMALE))
                                {
                                    string[] playerLines = File.ReadAllLines(PATHFAVPLAYERSFEMALE);
                                    playerLines.ToList().ForEach(l =>
                                    {
                                        string[] playerParts = l.Split(DEL);
                                        if (playerParts[0].Equals(p.Name))
                                        {
                                            p.Picture = playerParts[2];
                                            //MessageBox.Show(p.Picture, "Titl");
                                        }
                                    });
                                }

                                players.Add(p);
                            });
                        }
                    });
                });
            }
            else
            {
                if (!File.Exists(PATHFAVTEAMMALE)) return;
                matches = repo.GetMaleMatches();

                string[] lines = File.ReadAllLines(PATHFAVTEAMMALE);
                lines.ToList().ForEach(line =>
                {
                    string[] parts = line.Split(DEL);
                    matches.ToList().ForEach(match =>
                    {
                        if (match.HomeTeam.Country == parts[0])
                        {
                            match.HomeTeamStatistics.StartingEleven.ForEach(info =>
                            {
                                Player p = new Player();
                                p.Name = info.Name;
                                p.Number = info.ShirtNumber;
                                p._Position = info.Position;
                                p.Captain = info.Captain;
                                p.Picture = PATHNOIMAGE;

                                if(File.Exists(PATHFAVPLAYERSMALE))
                                {
                                    string[] playerLines = File.ReadAllLines(PATHFAVPLAYERSMALE);
                                    playerLines.ToList().ForEach(l =>
                                    {
                                        string[] playerParts = l.Split(DEL);
                                        if (playerParts[0].Equals(p.Name))
                                        {
                                            p.Picture = playerParts[2];
                                            //MessageBox.Show(p.Picture, "Titl");
                                        }
                                    });
                                }

                                players.Add(p);
                            });
                        }
                    });
                });
            }

            /*
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
            });*/

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
            

            if (IsPlayerFavorite(player))
            {
                panel.Click += (s, e) =>
                {
                    selectedFavoritePlayer = (s as Control).Tag.ToString();
                    //MessageBox.Show(selectedFavoritePlayer, "Titl");
                    if (Config.getGender() == "FEMALE")
                    {
                        if(File.Exists(PATHFAVPLAYERSFEMALE))
                        {
                            string[] lines = File.ReadAllLines(PATHFAVPLAYERSFEMALE);
                            lines.ToList().ForEach(line =>
                            {
                                if(line.Equals(selectedFavoritePlayer))
                                {
                                    string[] parts = line.Split(DEL);
                                    ImageUtils.SetImage(pbPlayer, parts[2]);
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
                                if (line.Equals(selectedFavoritePlayer))
                                {
                                    string[] parts = line.Split(DEL);
                                    ImageUtils.SetImage(pbPlayer, parts[2]);
                                }
                            });
                        }
                    }
                };
                flpRight.Controls.Add(panel);
            }
            else
            {
                panel.MouseClick += (s, e) =>
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        Point point = new Point(e.X, e.Y);
                        ctxMSRegular.Show(point);
                        selectedPlayer = (s as Control).Tag.ToString();
                    }
                };
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
            players.Clear();
            flpLeft.Controls.Clear();
            flpRight.Controls.Clear();
            LoadPlayers();
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

            players.Clear();
            flpLeft.Controls.Clear();
            flpRight.Controls.Clear();
            LoadPlayers();
        }

        /*
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
        }*/

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(selectedFavoritePlayer != "")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select Image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string iName = dialog.SafeFileName;
                        string filepath = dialog.FileName;
                        File.Copy(filepath, PATHIMAGES + iName);

                        if(Config.getGender() == "FEMALE")
                        {
                            if(File.Exists(PATHFAVPLAYERSFEMALE))
                            {
                                string[] lines = File.ReadAllLines(PATHFAVPLAYERSFEMALE);
                                List<string> newLines = new List<string>();
                                lines.ToList().ForEach(line =>
                                {
                                    if (line.Equals(selectedFavoritePlayer))
                                    {
                                        string[] parts = line.Split(DEL);
                                        string newLine = parts[0] + DEL + parts[1] + DEL + PATHIMAGES + iName;
                                        //MessageBox.Show(newLine, "Titl");
                                        newLines.Add(newLine);
                                    }
                                    else
                                    {
                                        newLines.Add(line);
                                    }
                                });

                                File.WriteAllLines(PATHFAVPLAYERSFEMALE, newLines);
                            }
                        }
                        else
                        {
                            if (File.Exists(PATHFAVPLAYERSMALE))
                            {
                                string[] lines = File.ReadAllLines(PATHFAVPLAYERSMALE);
                                List<string> newLines = new List<string>();
                                lines.ToList().ForEach(line =>
                                {
                                    if (line.Equals(selectedFavoritePlayer))
                                    {
                                        string[] parts = line.Split(DEL);
                                        string newLine = parts[0] + DEL + parts[1] + DEL + PATHIMAGES + iName;
                                        //MessageBox.Show(newLine, "Titl");
                                        newLines.Add(newLine);
                                    }
                                    else
                                    {
                                        newLines.Add(line);
                                    }
                                });

                                File.WriteAllLines(PATHFAVPLAYERSMALE, newLines);
                            }
                        }

                        players.Clear();
                        flpLeft.Controls.Clear();
                        flpRight.Controls.Clear();
                        LoadPlayers();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Unable to open file " + exp.Message);
                    }
                }
                else
                {
                    dialog.Dispose();
                }
            }
        }

        private void tSMIExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void tSMISettings_Click(object sender, EventArgs e)
        {
            new Initial_settings().Show();
            Hide();
        }

        private void tMIRankings_Click(object sender, EventArgs e)
        {
            new Rankings().Show();
            Hide();
        }
    }
}
