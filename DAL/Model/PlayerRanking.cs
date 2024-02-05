using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PlayerRanking : IComparable<PlayerRanking>
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; }
        public int YellowCards { get; set; }

        public int CompareTo(PlayerRanking other)
        {
            int goalsComparison = other.GoalsScored.CompareTo(this.GoalsScored);

            if (goalsComparison == 0)
            {
                return this.YellowCards.CompareTo(other.YellowCards);
            }

            return goalsComparison;
        }

        public override bool Equals(object obj)
        {
            return obj is PlayerRanking ranking &&
                   Name == ranking.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString() => $"{Name}\t\tGoals: {GoalsScored}\t\tYellow Cards: {YellowCards}";
    }
}
