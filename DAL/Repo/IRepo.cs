using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IRepo
    {
        IList<Team> GetMaleTeams();
        IList<Team> GetFemaleTeams();
        IList<Match> GetMaleMatches();
        IList<Match> GetFemaleMatches();
        IList<GroupResult> GetMaleGroupResults();
        IList<GroupResult> GetFemaleGroupResults();
        IList<Match> GetMaleMatchesForCountry(string fifaCode);
        IList<Match> GetFemaleMatchesForCountry(string fifaCode);
    }
}
