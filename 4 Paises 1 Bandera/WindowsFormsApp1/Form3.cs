using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form0();
            Formulario.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form1();
            Formulario.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form4();
            Formulario.Show();
            Hide();
        }
    }
}
