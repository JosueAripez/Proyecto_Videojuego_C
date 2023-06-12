using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Formulario = new Form3();
            Formulario.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:\4letras\score.txt";

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string contenido = sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Puntajes:\n" + contenido);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "https://josuearipez.wixsite.com/abraham-y-josue";

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la página web: " + ex.Message);
            }
        }
    }
}
