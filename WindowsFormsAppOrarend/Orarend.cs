using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppOrarend;
using static WindowsFormsAppOrarend.Program;

namespace WindowsFormsAppOrarend
{
    internal class Orarend
    {
        public int oraid;
        public string tantargy;
        public int sorszam;
        public HetNapja hetnapja;

        public Orarend(int oraid, string tantargy, int sorszam, HetNapja hetnapja)
        {
            this.oraid = oraid;
            this.tantargy = tantargy;
            this.sorszam = sorszam;
            this.hetnapja = hetnapja;
        }

        public override string ToString()
        {
            return $"{hetnapja}";
        }
    }
}
