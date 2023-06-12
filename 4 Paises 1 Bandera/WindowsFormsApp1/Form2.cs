using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(string puntuacion)
        {
            InitializeComponent();
            this.label2.Text = puntuacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form3();
            Formulario.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = jugadorNombre.Text;
            string rutaArchivo =  @"C:\4letras\score.txt"; ;
            
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }

            string contenido = nombre + "," + label2.Text;
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(contenido);
                sw.Close();
            }
            MessageBox.Show("Se guardo su puntaje de forma correcta:" + contenido);

            Form Formulario = new Form3();
            Formulario.Show();
            Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
