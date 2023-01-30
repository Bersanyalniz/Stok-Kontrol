using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace stokürünkontrolü
{
    public partial class FrmTanımla : Form
    {
        public FrmTanımla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"//urunler.txt", true);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            MessageBox.Show("kaydedildi");
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
