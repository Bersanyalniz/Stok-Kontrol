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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\urunler.txt", true);

            while (!sr.EndOfStream)
            {
                comboBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
