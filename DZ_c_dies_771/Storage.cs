using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_dies_771
{
    public abstract class Storage
    {
        public string Nome { get; set; }
        public string Model { get; set; }
        public double Volume { get; set; }
        public double Rapid { get; set; }
        public virtual void Info() { }
        public abstract double Memory();
        public abstract void Copy(double dan);
        public abstract double FreeMem();

    }
}
