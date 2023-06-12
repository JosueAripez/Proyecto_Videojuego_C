using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        int numeroDeVidas = 3, numeroDeImagen = 0, numeroPuntaje = 0;
        Assembly assembly = Assembly.GetExecutingAssembly();

        string[,] arregloJuego = {
                            {"Andorra", "Australia", "Brasil", "Canadá"},
                            {"China", "Colombia", "Egipto", "Emiratos arabes unidos"},
                            {"Alemania", "India", "Indonesia", "Afganistan"},
                            {"Japón", "Antigua y Barbuda", "Países Bajos", "Rusia"},
                            {"Albania", "Reino Unido", "Estados Unidos", "Sudáfrica"},
                            {"Corea del Sur", "Armenia", "Ucrania", "Emiratos Árabes Unidos"},
                            {"Afganistán", "Bolivia", "Angola", "Dinamarca"},
                            {"Ecuador", "Finlandia", "Grecia", "Tratado Antartico"},
                            {"Argentina", "Jamaica", "Kenia", "Líbano"},
                            {"Malasia", "Nueva Zelanda", "Samoa Americana", "Perú"},
                            {"Polonia", "Austria", "Singapur", "Suecia"},
                            {"Suiza", "Tailandia", "Uruguay", "Australia"},
                            {"Aruba", "Zambia", "Zimbabwe", "Portugal"},
                            {"República Checa", "Israel", "Aland", "Marruecos"}
                          };

        string[,] respuestas = { {"Andorra","ad" }, {"Emiratos arabes unidos", "ae"},{ "Afganistan", "af" },
                                { "Antigua y Barbuda","ag" }, {"Albania","al" }, {"Armenia","am"},
                                { "Angola","ao" }, {"Tratado Antartico","aq" }, {"Argentina","ar"},
                                { "Samoa Americana","as" }, {"Austria","at"}, {"Australia", "au" },
                                {"Aruba","aw" }, {"Aland","ax"}};

        string rutaBase = "WindowsFormsApp1.Resources.";

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int compara = revisaRespuesta(this.opcion1.Text);
            if (compara == 0)
            {
                this.opcion1.BackColor = Color.Red;
            }
        }

        private int revisaRespuesta(string textoButton)
        {
            if (respuestas[numeroDeImagen, 0] == textoButton)
            {
                aumentaPuntaje();
                cambiaImagen();
                resetColorButton();
                return 1;
            }
            else
            {
                restaVida();
                return 0;
            }

        }

        private void resetColorButton()
        {
            this.opcion1.BackColor = SystemColors.Control;
            this.opcion2.BackColor = SystemColors.Control;
            this.opcion3.BackColor = SystemColors.Control;
            this.opcion4.BackColor = SystemColors.Control;
        }

        private void cambiaImagen()
        {
            numeroDeImagen = numeroDeImagen + 1;
            string rutaImagen = rutaBase + respuestas[numeroDeImagen, 1] + ".png";
            using (Stream stream = assembly.GetManifestResourceStream(rutaImagen))
            {
                Image imagen = Image.FromStream(stream);
                this.pictureBox1.Image = imagen;
            }
            this.opcion1.Text = arregloJuego[numeroDeImagen, 0];
            this.opcion2.Text = arregloJuego[numeroDeImagen, 1];
            this.opcion3.Text = arregloJuego[numeroDeImagen, 2];
            this.opcion4.Text = arregloJuego[numeroDeImagen, 3];
        }

        private void aumentaPuntaje()
        {
            numeroPuntaje = numeroPuntaje + 1;
            this.puntaje.Text = numeroPuntaje.ToString();
            if (numeroPuntaje == respuestas.GetLength(0))
            {

                Form2 puntuacionFinalModal = new Form2(numeroPuntaje.ToString());
                puntuacionFinalModal.ShowDialog();
            }
        }

        private void opcion2_Click(object sender, EventArgs e)
        {
            int compara = revisaRespuesta(this.opcion2.Text);
            if (compara == 0)
            {
                this.opcion2.BackColor = Color.Red;
            }
        }

        private void opcion3_Click(object sender, EventArgs e)
        {
            int compara = revisaRespuesta(this.opcion3.Text);
            if (compara == 0)
            {
                this.opcion3.BackColor = Color.Red;
            }
        }

        private void opcion4_Click(object sender, EventArgs e)
        {
            int compara = revisaRespuesta(this.opcion4.Text);
            if (compara == 0)
            {
                this.opcion4.BackColor = Color.Red;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Formulario = new Form3();
            Formulario.Show();
            Hide();
        }

        private void restaVida()
        {
            numeroDeVidas = numeroDeVidas - 1;
            this.numeroVidasRestantes.Text = numeroDeVidas.ToString();
            if (numeroDeVidas == 0)
            {

                Form2 puntuacionFinalModal = new Form2(numeroPuntaje.ToString());
                puntuacionFinalModal.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = rutaBase + respuestas[numeroDeImagen, 1] + ".png";
            using (Stream stream = assembly.GetManifestResourceStream(rutaImagen))
            {
                Image imagen = Image.FromStream(stream);
                this.pictureBox1.Image = imagen;
            }

            this.opcion1.Text = arregloJuego[0, 0];
            this.opcion2.Text = arregloJuego[0, 1];
            this.opcion3.Text = arregloJuego[0, 2];
            this.opcion4.Text = arregloJuego[0, 3];
        }
    }
}
