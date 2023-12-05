using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Bejelentkezes_Click(object sender, EventArgs e)
        {
            if (Program.db.Bejelentkezes(textBox_Felhasznalonev.Text, textBox_Jelszo.Text) >= 0)
            {
                Program.formOrarend.Show();
            }
        }
    }
}
