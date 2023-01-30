﻿using System;
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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void FrmGiriş_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\urunler.txt",true);

            while (!sr.EndOfStream)
            {
                comboBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bilgi = comboBox1.Text + ";" + "1" + ";" + textBox1.Text;
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\hareket.txt", true);
            sw.WriteLine(bilgi);
            MessageBox.Show("ürünler alındı");
            sw.Close();



        }
    }
}
