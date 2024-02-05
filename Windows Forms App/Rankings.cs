using DAL.Model;
using DAL.Repo.Config;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App
{
    public partial class Rankings : Form
    {
        ISet<PlayerRanking> players = new HashSet<PlayerRanking>();
        IList<Match> matches = new List<Match>();
        IList<MatchRanking> rankMatches = new List<MatchRanking>();
        IList<TeamEvent> events = new List<TeamEvent>();

        public Rankings()
        {
            InitializeComponent();
            LoadMatches();
            LoadPlayers();
            LoadEvents();
            UpdatePlayerData();
            LoadListPlayers();
            LoadMatchRankings();
            LoadListMatches();
        }

        private void LoadMatchRankings()
        {
            matches.ToList().ForEach(match =>
            {
                MatchRanking ranking = new MatchRanking();
                ranking.NumberOfVisitors = match.Attendance;
                ranking.Location = match.Location;
                ranking.HomeTeam = match.HomeTeam;
                ranking.AwayTeam = match.AwayTeam;

                rankMatches.Add(ranking);
            });
        }

        private void LoadListMatches()
        {
            lbMatches.Items.Clear();
            List<MatchRanking> rankingMatchForList = rankMatches.ToList();
            rankingMatchForList.Sort();
            rankingMatchForList.ForEach(match =>
            {
                lbMatches.Items.Add(match);
            });
        }

        private void LoadListPlayers()
        {
            lbPlayers.Items.Clear();
            List<PlayerRanking> playerForList = players.ToList();
            playerForList.Sort();
            playerForList.ForEach(player =>
            {
                lbPlayers.Items.Add(player);
            });
        }

        private void UpdatePlayerData()
        {
            events.ToList().ForEach(e =>
            {
                string player = e.Player;
                players.ToList().ForEach(p =>
                {
                    if(p.Name.Equals(player))
                    {
                        if(e.TypeOfEvent == TypeOfEvent.YellowCard 
                        || e.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            p.YellowCards++;
                        }
                        else if(e.TypeOfEvent == TypeOfEvent.Goal
                        || e.TypeOfEvent == TypeOfEvent.GoalOwn
                        || e.TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            p.GoalsScored++;
                        }
                    }
                });
            });
        }

        private void LoadMatches()
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
        }

        private void LoadEvents()
        {
            matches.ToList().ForEach(match =>
            {
                match.HomeTeamEvents.ForEach(teamEvent =>
                {
                    events.Add(teamEvent);
                });
                match.AwayTeamEvents.ForEach(teamEvent =>
                {
                    events.Add(teamEvent);
                });
            });
        }

        private void LoadPlayers()
        {
            matches.ToList().ForEach(match =>
            {
                match.HomeTeamStatistics.StartingEleven.ToList().ForEach(player =>
                {
                    PlayerRanking newPlayer = new PlayerRanking();
                    newPlayer.Name = player.Name;
                    newPlayer.YellowCards = 0;
                    newPlayer.GoalsScored = 0;
                    players.Add(newPlayer);
                });
                match.AwayTeamStatistics.StartingEleven.ToList().ForEach(player =>
                {
                    PlayerRanking newPlayer = new PlayerRanking();
                    newPlayer.Name = player.Name;
                    newPlayer.YellowCards = 0;
                    newPlayer.GoalsScored = 0;
                    players.Add(newPlayer);
                });
            });
        }

        private void tMIFavorites_Click(object sender, EventArgs e)
        {
            new Favorite_National_Team().Show();
            Hide();
        }
    }
}
