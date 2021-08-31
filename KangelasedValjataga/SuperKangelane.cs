using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangelasedValjataga
{
    class SuperKangelane:Kangelane
    {

        private static readonly Random random = new Random();
        private double _osavus;
    public SuperKangelane(string nimi, string asukoht):base(nimi, asukoht)
        {
            _osavus = random.NextDouble() * (5 - 1) + 1;
        }
    public override int Päästa(int ohustatuid)
        {
            return Convert.ToInt32(ohustatuid * (95 + _osavus) / 100);

        }
        public override string ToString()
        {
            return base.ToString()+$"\nLisaks on ta {_osavus:N2}% võimekam kui tavakangelane.";
        }
    }
}
