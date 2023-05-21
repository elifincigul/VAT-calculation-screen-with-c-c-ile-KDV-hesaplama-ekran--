using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urunkdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int label2, label3;
            label2 = Convert.ToInt32(txturunfiyati.Text);
            label3 = Convert.ToInt32(txtkdv.Text);
            int carpma;
            carpma = label2 * label3;
            MessageBox.Show("Sayıların carpımı=" + carpma.ToString());
        }

        private void txtürünfiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkdv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
