using DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DAL.Repo.FileRepo
{
    internal class FileRepo : IRepo
    {
        private const string PATHMEN = @"../../../../DAL/worldcup.sfg.io/men/";
        private const string PATHWOMEN = @"../../../../DAL/worldcup.sfg.io/women/";

        public IList<GroupResult> GetFemaleGroupResults()
        {
            string filename = $"group_results.json";
            return JsonConvert.DeserializeObject<List<GroupResult>>(File.ReadAllText(PATHWOMEN + filename));
        }

        public IList<Match> GetFemaleMatches()
        {
            string filename = $"matches.json";
            return JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(PATHWOMEN + filename));
        }

        public IList<Match> GetFemaleMatchesForCountry(string fifaCode)
        {
            string filename = $"matches.json";
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(PATHWOMEN + filename));

            matches.RemoveAll(match => match.HomeTeam.Code != fifaCode && match.AwayTeam.Code != fifaCode);

            return matches;
        }

        public IList<Team> GetFemaleTeams()
        {
            string filename = $"results.json";
            return JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(PATHWOMEN + filename));
        }

        public IList<GroupResult> GetMaleGroupResults()
        {
            string filename = $"group_results.json";
            return JsonConvert.DeserializeObject<List<GroupResult>>(File.ReadAllText(PATHMEN + filename));
        }

        public IList<Match> GetMaleMatches()
        {
            string filename = $"matches.json";
            return JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(PATHMEN + filename));
        }

        public IList<Match> GetMaleMatchesForCountry(string fifaCode)
        {
            string filename = $"matches.json";
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(PATHMEN + filename));

            matches.RemoveAll(match => match.HomeTeam.Code != fifaCode && match.AwayTeam.Code != fifaCode);

            return matches;
        }

        public IList<Team> GetMaleTeams()
        {
            string filename = $"results.json";
            return JsonConvert.DeserializeObject<List<Team>>(File.ReadAllText(PATHMEN + filename));
        }
    }
}
