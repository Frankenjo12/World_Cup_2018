using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class InitialSettings
    {
        public string Gender { get; set; }
        public string Language { get; set; }
        public string Repository { get; set; }

        public override string ToString() => $"{Gender}, {Language}, {Repository}";
    }
}
