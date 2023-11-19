using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public class Flash:Storage
    {
        public string Nome { get; set; }
        public string Model { get; set; }
        public double Volume { get; set; }
        public double Volume2 { get; set; }
        public double Rapid { get; set; }


        public Flash(string nome, string model, double volume)
        {
            Nome = nome;Rapid = 600;
            Model = model;
            Volume = volume;
            Volume2 = volume;
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
