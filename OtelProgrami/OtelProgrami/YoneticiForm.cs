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
    public partial class YoneticiForm : Form
    {
        OdaveOtelEkle ekle = new OdaveOtelEkle();
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void YöneticiForm_Load(object sender, EventArgs e)
        {
            comboBox_odaOzelligi.SelectedIndex = 0;
            comboBox_odaTuru.SelectedIndex = 0;
            comboBox_otelTuru.SelectedIndex = 0;
            radioButton_ucYildiz.Checked = true;
            uyeListesiDataGrid.Visible = false;

        }

        private void button_rezSorgu_Click(object sender, EventArgs e)
        {
            uyeListesiDataGrid.Visible = true;
            Yonetici deneme = new Yonetici();
            foreach (var element in deneme.Listele())
            {
                uyeListesiDataGrid.Rows.Add(element.Ad, element.Soyad, element.TelNo, element.TcNo, "cc", "cc", "d", "df");
            }
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            ekle.Show();
        }
    }
}
