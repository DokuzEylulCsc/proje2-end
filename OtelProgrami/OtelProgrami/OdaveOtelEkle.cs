﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProgrami
{
    public partial class OdaveOtelEkle : Form
    {
        int i = 1;
        private object odaOtelIsim;
        private object otelYildiz;

        public OdaveOtelEkle()
        {
            InitializeComponent();
        }

        public int I { get => i; set => i = value; }

        private void odaEkle_Click(object sender, EventArgs e)
        {
            //string otelAd = odaOtelIsim.Text;
            int odaFiyati = Int32.Parse(odaFiyat.Text);
            string odaTuru = comboBox_OdaTuru.Text;
            string otelIsmi = comboBox_OtelIsmi.Text;
            string odaOzelligi = comboBox_odaOzellik.Text;
            bool rezBilgisi = false;         
            //Oda oda = new Oda(otelAd, odaFiyati, kisiKap, klimaBilgisi, minibarBilgisi, denizBilgisi, dagBilgisi, ekoBilgisi, rezBilgisi);
           // CiftKisilikOda oda = new CiftKisilikOda();
          //  oda.OdaBilgiGir(otelAd, odaFiyati, kisiKap, klimaBilgisi, minibarBilgisi, denizBilgisi, dagBilgisi, ekoBilgisi, rezBilgisi);
            //oda.OdaEkle(I);
            I++;
        }

        private void otelEkle_Click(object sender, EventArgs e)
        {
            string otelIsmi = otelIsim.Text;
            string sehir = otelSehir.Text;
            string otelTur = otelTuru.Text;
            int yildiz;
            if (radioButton_ucYildiz.Checked)
            {
                yildiz = 3;
            }
            else if (radioButton_dortYildiz.Checked)
            {
                yildiz = 4;
            }
            else yildiz = 5;
            //Otel otel = new Otel(otelIsmi, sehir, yildizSy, otelTur);
            //otel.OtelEkle();
        }
    }
}
