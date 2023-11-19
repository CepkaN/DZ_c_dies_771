using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public class Comp
    {
        public List<Storage> STR { get; set; }
        public double Volume { get; set; }
        public double Maj { get; set; }
        public Comp()
        {
            STR=new List<Storage>();Volume = 0;Maj = 0;
        }
        public void Add(Storage srt)
        {
            STR.Add(srt);
        }
        public void MemComp()
        {
            foreach (var i in STR)
            {
                Volume += i.FreeMem();
                Console.WriteLine(Volume);
            }
        }
        public void MeCopy(double inf)
        {
            Maj = 0;
            double inf2 = inf;
            foreach (var i in STR)
            {
                if (inf2 <= i.FreeMem())
                {
                    i.Copy(inf2);
                    Maj = Maj + inf2 / i.Rapid;
                    inf2 = 0;
                }
                else if (inf2 > i.FreeMem())
                {
                    Maj += i.Volume / i.Rapid;
                    inf2 = inf2 - i.FreeMem();
                    i.Copy(i.FreeMem());
                }
                else Console.WriteLine("Ошибка1");
                if (inf2 == 0) { Console.WriteLine("Данные скопированы"); return; }
            }

        }
        public void Temp()
        {
            Console.WriteLine("Время копирования " + Maj.ToString());
        }
        public void InfoQuan(double inf)
        {
            double inf2 = inf;
            foreach (var i in STR)
            {
                if (inf2 <= i.FreeMem())
                {
                    i.Info();
                    Console.WriteLine("Вам хватит памяти"); return;
                }
                if (inf2 > i.FreeMem())
                {
                    i.Info();
                    inf2 = inf2 - i.FreeMem();
                }

            }
            Console.WriteLine(" Вам нужна еще память в кооличестве " + inf2);
        }
    }
}
