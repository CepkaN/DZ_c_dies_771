using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public class MnogoFigure
    {
        public List<Figura> FFF { get; set; }
        public MnogoFigure() { FFF = new List<Figura>(); }
        public void AddFig(Figura figura)
        {
            FFF.Add(figura);
        }
        public void Mostr(int a)
        {
            foreach(var F in FFF)
            {
                F.Mostra(a);
            }
        }
    }
}
