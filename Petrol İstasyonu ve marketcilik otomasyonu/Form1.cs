using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_İstasyonu_ve_marketcilik_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double D_Benzin = 0, D_Dizel = 0, D_LPG = 0;
        double E_Benzin = 0, E_Dizel = 0, E_LPG = 0;
        string[] depo_bilgileri;

        private void txt_depo_oku()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Depo.txt");
            D_Benzin = Convert.ToDouble(depo_bilgileri[0]);
            D_Dizel = Convert.ToDouble(depo_bilgileri[1]);
            D_LPG = Convert.ToDouble(depo_bilgileri[2]);

        }
        private void txt_depo_yaz()
        {
            label1.Text=D_Benzin.ToString("N");
            label2.Text=D_Dizel.ToString("N");
            label3.Text=D_LPG.ToString("N");
        }
        private void progressBar_guncelle()
        {
            progressBar1.Value = Convert.ToInt16(D_Benzin);
            progressBar2.Value = Convert.ToInt16(D_Dizel);
            progressBar3.Value = Convert.ToInt16(D_LPG);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
        }
    }
}
