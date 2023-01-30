using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokürünkontrolü
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTanımla frm = new FrmTanımla();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGiriş frm = new FrmGiriş();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmÇıkış frm = new FrmÇıkış();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRapor frm = new FrmRapor();
            frm.ShowDialog();
        }
    }
}
