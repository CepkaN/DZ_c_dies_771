using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public class RangeOfArray
    {
        public int a { get; set; }
        public int b { get; set; }
        public List<int> Mass { get; set; }
        public RangeOfArray(int a1,int b1) { a=a1; b = b1;Mass = new List<int> { }; }
        public void AddMass(int a) { Mass.Add(a);}
        public void Mostra()
        {
            int y = a;
            for(int i = 0; i < Mass.Count; ++i)
            {
                Console.WriteLine(y + " -ый элемент : " + Mass[i]);
                y++;
            }
        }
        public void Cislo(int indice)
        {
            int Y = b - a;
            int h = 0;
            if (indice >= a && indice < b)
            {
                for(int i = a; i < Mass.Count; ++i)
                {
                    if (i == indice)
                    {
                        Console.WriteLine(" Число " + Mass[h]);return;
                    }
                    h++;
                }
            }
        }
    }
}
