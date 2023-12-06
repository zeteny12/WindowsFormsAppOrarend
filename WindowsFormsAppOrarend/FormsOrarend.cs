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
    public partial class FormsOrarend : Form
    {
        public FormsOrarend()
        {
            InitializeComponent();
        }

        private void FormsOrarend_Load(object sender, EventArgs e)
        {
            Program.db.napokBetoltese();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox_OrarendNapok.Items.Clear();
            foreach (var orarend in Program.db.OrarendLista)
            {
                listBox_OrarendNapok.Items.Add(orarend.ToString());
            }
        }
    }
}
