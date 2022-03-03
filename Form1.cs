using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);

            MessageBox.Show(CelaCisla.Mocnina(x,y).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CelaCisla.Faktorial(12).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CelaCisla.CifLichSoucet(1023).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CelaCisla.JePrvocislo(4)) MessageBox.Show("Cislo je prvocislo");
            else MessageBox.Show("Cislo neni prvocislo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pocet sudých dělitelů je: " + CelaCisla.PocetDeliteluSud(8));
        }
    }
}
