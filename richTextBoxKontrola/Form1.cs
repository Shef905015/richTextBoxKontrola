using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:Tempproba.rtf");

            MessageBox.Show("Tekst je spremljen");
        }
    }
}
