using System;
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
    public partial class OtelRezervasyon : Form
    {
        public OtelRezervasyon()
        {
            InitializeComponent();
        }

        private void OtelRezervasyon_Load(object sender, EventArgs e)
        {
            comboBox_OdaTuru.SelectedIndex = 0;
            comboBox_OtelTuru.SelectedIndex = 0;
            comboBox_odaOzellik.SelectedIndex = 0;
            uc_yildiz.Checked = true;
        }

        private void button_rezYap_Click(object sender, EventArgs e)
        {

            DateTime giris = dateTimePicker_Giris.Value.Date;
            DateTime cikis = dateTimePicker_Cikis.Value.Date;
            int yildiz;
            string otelTuru = comboBox_OtelTuru.Text;
            string odaTuru = comboBox_OdaTuru.Text;
            if (uc_yildiz.Checked)
            {
                yildiz = 3;
                //dort_yildiz.Checked = false;
                //bes_yildiz.Checked = false;
            }
            else if (dort_yildiz.Checked)
            {
                //uc_yildiz.Checked = false;
                //bes_yildiz.Checked = false;
                yildiz = 4;
            }
            else
            {
                //uc_yildiz.Checked = false;
                //dort_yildiz.Checked = false;
                yildiz = 5;
            }
            MessageBox.Show(" " + otelTuru + " , " + odaTuru + " ve " + yildiz + " yıldızlı otele " + giris.ToString("dd/MM/yyyy") + " - " + cikis.ToString("dd/MM/yyyy") + " tarihleri arasinda rezervasyon yaptınız.");
        }


    }
}
