using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class MatchRanking : IComparable<MatchRanking>
    {
        public long NumberOfVisitors { get; set; }
        public string Location { get; set; }
        public Team HomeTeam{ get; set; }
        public Team AwayTeam { get; set; }

        public int CompareTo(MatchRanking other)
        {
            return -this.NumberOfVisitors.CompareTo(other.NumberOfVisitors);
        }

        public override string ToString() => $"Visitors: {NumberOfVisitors}\t{Location}\tHome: {HomeTeam}\tAway: {AwayTeam}";
    }
}
