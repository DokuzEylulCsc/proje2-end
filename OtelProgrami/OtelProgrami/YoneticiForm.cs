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
        }

      
    }
}
