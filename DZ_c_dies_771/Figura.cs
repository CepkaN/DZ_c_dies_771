using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public abstract class Figura
    {
        public string Nome { get; set; }
        public virtual void Mostra(int a) { }
    }
    public class Rettangolo : Figura
    {
        public string Nome { get; set; }
        public Rettangolo() { Nome = " Прямоугольник "; }
        public override void Mostra(int a)
        {
            if (a == 0)
            {
                Console.ResetColor();
                Console.WriteLine(Nome + "\n######\n#    #\n#    #\n######\n");
            }
            else { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Nome + "\n######\n#    #\n#    #\n######\n");
        }

        }
    }
    public class Rombo : Figura
    {
        public string Nome { get; set; }
        public Rombo() { Nome = " Ромб "; }
        public override void Mostra(int a)
        {
            if (a == 0)
            {
                Console.ResetColor();
                Console.WriteLine(Nome +
                    "\n   #   " +
                    "\n  ###" +
                    "\n #####" +
                    "\n#######" +
                    "\n #####" +
                    "\n  ###" +
                    "\n   #");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Nome +
                    "\n   #   " +
                    "\n  ###" +
                    "\n #####" +
                    "\n#######" +
                    "\n #####" +
                    "\n  ###" +
                    "\n   #");
            }

        }
    }
        public class Triangolo : Figura
        {
            public string Nome { get; set; }
            public Triangolo() { Nome = " Треугольник "; }
            public override void Mostra(int a)
            {
                if (a == 0)
                {
                    Console.ResetColor();
                    Console.WriteLine(Nome +
                        "\n   #" +
                        "\n  ###" +
                        "\n #####" +
                        "\n#######\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Nome +
                        "\n   #" +
                        "\n  ###" +
                        "\n #####" +
                        "\n#######\n");
                }
            }
        }
            public class Trapezio : Figura
            {
                public string Nome { get; set; }
                public Trapezio() { Nome = " Трапеция "; }
                public override void Mostra(int a)
                {
                    if (a == 0)
                    {
                        Console.ResetColor();
                        Console.WriteLine(Nome +
                        "\n  ####" +
                        "\n ######" +
                        "\n########\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Nome +
                        "\n  ####" +
                        "\n ######" +
                        "\n########\n");
                    }
                }
            }
                public class Poligono : Figura
                {
                    public string Nome { get; set; }
                    public Poligono() { Nome = " Многоугольник "; }
                    public override void Mostra(int a)
                    {
                        if (a == 0)
                        {
                            Console.ResetColor();
                            Console.WriteLine(Nome +
                                "\n#  #  #" +
                                "\n  ###  " +
                                "\n#######" +
                                "\n  ###  " +
                                "\n#  #  #\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(Nome +
                               "\n#  #  #" +
                               "\n  ###  " +
                               "\n#######" +
                               "\n  ###  " +
                               "\n#  #  #\n");
                        }
                    }
                }
}
