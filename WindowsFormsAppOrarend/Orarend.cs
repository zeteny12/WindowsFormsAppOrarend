using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppOrarend
{
    internal class Orarend
    {
        public int oraid;
        public string tantargy;
        public int sorszam;
        public int hetnapja;

        public Orarend(int oraid, string tantargy, int sorszam, int hetnapja)
        {
            this.oraid = oraid;
            this.tantargy = tantargy;
            this.sorszam = sorszam;
            this.hetnapja = hetnapja;
        }

        public override string ToString()
        {
            return $"{tantargy}";
        }
    }
}
