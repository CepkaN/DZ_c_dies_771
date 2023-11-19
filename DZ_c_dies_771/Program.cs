namespace DZ_c_dies_771
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comp comp = new Comp();
            Storage flashka = new Flash("Флешка", "какая-то", 2000);
            Storage dvd = new DVD("DVD", "какой-то", 1.3, 1);
            List<double> mass = new List<double> { 20000.0, 30000.0, 10000.0 };
            Storage hdd = new HDD("HDD", "какой-то", mass);
            hdd.Memory();
            flashka.Memory();
            dvd.Memory();
            comp.Add(flashka);
            comp.Add(dvd);
            comp.Add(hdd);
            comp.MemComp();
            comp.InfoQuan(3000);
            comp.MeCopy(3000);
            comp.Temp();

            RangeOfArray ROA = new RangeOfArray(21, 30);
            List<int> R = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            ROA.Mass = R;
            ROA.Mostra();

            Rombo rrr= new Rombo();
            Rettangolo ret = new Rettangolo();
            Triangolo tri=new Triangolo();
            Trapezio trap=new Trapezio();
            Poligono pol=new Poligono();
            MnogoFigure MF=new MnogoFigure();
            MF.AddFig(rrr);MF.AddFig(ret);MF.AddFig(tri);MF.AddFig(trap);MF.AddFig(pol);

            ret.Mostra(1);
            MF.Mostr(1);

        }
    }
    
}