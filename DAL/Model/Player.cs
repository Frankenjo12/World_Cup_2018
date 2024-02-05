using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Player
    {
        public string Name { get; set; }
        public long Number { get; set; }
        public Position _Position { get; set; }
        public bool Captain { get; set; }
        public string Picture { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Number == player.Number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Number);
        }

        public override string ToString()
        {
            return $"{Name}|{Number}|{Picture}";
        }
    }
}
