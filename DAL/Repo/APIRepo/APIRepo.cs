using DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.APIRepo
{
    internal class APIRepo : IRepo
    {
        public IList<GroupResult> GetFemaleGroupResults()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/women/teams/group_results") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<GroupResult>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Match> GetFemaleMatches()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/women/matches") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Match>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Match> GetFemaleMatchesForCountry(string fifaCode)
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=" + fifaCode) as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Match>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Team> GetFemaleTeams()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/women/teams/results") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Team>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<GroupResult> GetMaleGroupResults()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/men/teams/group_results") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<GroupResult>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Match> GetMaleMatches()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/men/matches") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Match>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Match> GetMaleMatchesForCountry(string fifaCode)
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=" + fifaCode) as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Match>>(resultsAsJson);
                    return results;
                }
            }
        }

        public IList<Team> GetMaleTeams()
        {
            var webRequest = WebRequest.Create("https://worldcup-vua.nullbit.hr/men/teams/results") as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var resultsAsJson = sr.ReadToEnd();
                    var results = JsonConvert.DeserializeObject<List<Team>>(resultsAsJson);
                    return results;
                }
            }
        }
    }
}
