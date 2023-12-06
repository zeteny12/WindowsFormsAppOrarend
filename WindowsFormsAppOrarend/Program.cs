using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    internal static class Program
    {
        public static FormLogin formLogin = null;
        public static FormsOrarend formOrarend = null;
        public static int UserId;
        public static Database db = new Database();
        public enum HetNapja
        {
            hétfő,
            kedd,
            szerda,
            csütörtök,
            péntek
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formLogin = new FormLogin();
            formOrarend = new FormsOrarend();
            Application.Run(formLogin);
        }
    }
}
