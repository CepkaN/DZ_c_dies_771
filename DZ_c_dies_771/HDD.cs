using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public class HDD:Storage
    {
        public string Nome { get; set; }
        public string Model { get; set; }
        public double Volume { get; set; }
        public double Volume2 { get; set; }
        public double Rapid { get; set; }
        public List<double> Mass { get; set; }

        public HDD(string nome, string model, List<double>m)
        {
            Nome = nome; Rapid = 60;Mass = m;
            Model = model;
            Volume = Mem();
            Volume2 = Mem();
        }
        public double Mem()
        {
            double V= 0;
            foreach(var m in Mass)
            {
                V += m;
            }
            return V;
        }
        public override void Info()
        {
            Console.WriteLine(" Наименование : " + Nome + "\n Модель " + Model + "\n Кол-во памяти : " + Volume + '\n');
        }
        public override double Memory() { return Volume2; }
        public override void Copy(double dan)
        {
            if (dan <= Volume)
            {
                Volume = Volume - dan;
                Console.WriteLine("Данные скопированы");
            }
            else Console.WriteLine("Недостаточно места");
        }
        public override double FreeMem()
        {
            return Volume;
        }
    }
}
