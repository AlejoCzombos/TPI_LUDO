using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Programacion___Ludo
{
    public partial class FormularioSeleccionColores : Form
    {
        /*
         * Este formulario se maneja en base a la cantidad de jugadores elegidos en la pantaalla de inicio
         */
        private int cantidadJugadores;

        //El booleano es para poder mostrar la pantalla principal si el usuario aprieta volver atras
        private bool cerrado;

        public FormularioSeleccionColores()
        {
            InitializeComponent();

            Cerrado = false;
        }

        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }
        public bool Cerrado { get => cerrado; set => cerrado = value; }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            if (CantidadJugadores == 1)
            {

            }
            else if (CantidadJugadores == 4)
            {
                if (NombresVacios())
                {
                    MessageBox.Show("Los nombres no pueden estar vacios", "Nombres vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Program.formulario.ReiniciarTablero();
                    Program.formulario.ActualizarNombres(textBoxR.Text, textBoxV.Text, textBoxA.Text, textBoxC.Text);
                    Program.formulario.ShowDialog();
                    this.Hide();
                }
            }
        }

        private bool NombresVacios()
        {
            return textBoxA.Text == "" || textBoxR.Text == "" || textBoxC.Text == "" || textBoxV.Text == "";
        }


        //Volver atras sirve para volver a elegir de nuevo el modo de juego
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            Cerrado = true;
            LimpiarTextBox();
            this.Close();
        }


        //Limpia los TextBoxs, una vez se volvió atrás
        private void LimpiarTextBox()
        {
            textBoxR.Text = "";
            textBoxV.Text = "";
            textBoxA.Text = "";
            textBoxC.Text = "";
        }
        private void ReiniciarTextBox()
        {
            textBoxV.Enabled = true;
            textBoxA.Enabled = true;
            textBoxC.Enabled = true;
            textBoxR.Enabled = true;
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (CantidadJugadores == 1) CondicionJvsPC_MouseMove(txtBox);
            else if (CantidadJugadores == 2) CondicionJvsJ_MouseMove(txtBox);
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (CantidadJugadores != 4) Condicion_MouseLeave(txtBox);

        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (CantidadJugadores == 1) CondicionJvsPC_MouseClick(txtBox);
            else if (CantidadJugadores == 2) CondicionJvsJ_MouseClick(txtBox);

        }

        //En JvsPC o JvsJ una vez el mouse haya abandonado un TextBox habilita los demas correspondientes
        private void Condicion_MouseLeave(TextBox txtBox)
        {
            //if (txtBox == textBoxR)
            //{
            //    textBoxA.Enabled = true;
            //    textBoxV.Enabled = true;
            //    textBoxC.Enabled = true;
            //}
            //if (txtBox == textBoxV)
            //{
            //    textBoxR.Enabled = true;
            //    textBoxA.Enabled = true;
            //    textBoxC.Enabled = true;
            //}
            //if (txtBox == textBoxA)
            //{
            //    textBoxR.Enabled = true;
            //    textBoxV.Enabled = true;
            //    textBoxC.Enabled = true;
            //}
            //if (txtBox == textBoxC)
            //{
            //    textBoxR.Enabled = true;
            //    textBoxV.Enabled = true;
            //    textBoxA.Enabled = true;
            //}
        }

        //En Jugador vs PC, solo se puede elegir uno, esto deshabilita los demas cuando el mouse se mueve por un TextBox
        private void CondicionJvsPC_MouseMove(TextBox txtBox)
        {
            textBoxV.Enabled = false;
            textBoxA.Enabled = false;
            textBoxC.Enabled = false;
            //if (txtBox == textBoxR)
            //{
            //    textBoxV.Enabled = false;
            //    textBoxA.Enabled = false;
            //    textBoxC.Enabled = false;
            //}
            //if (txtBox == textBoxV)
            //{
            //    textBoxR.Enabled = false;
            //    textBoxA.Enabled = false;
            //    textBoxC.Enabled = false;
            //}
            //if (txtBox == textBoxA)
            //{
            //    textBoxR.Enabled = false;
            //    textBoxV.Enabled = false;
            //    textBoxC.Enabled = false;
            //}
            //if (txtBox == textBoxC)
            //{
            //    textBoxR.Enabled = false;
            //    textBoxV.Enabled = false;
            //    textBoxA.Enabled = false;
            //}
        }

        /*
         * En Jugador vs PC, cuando el jugador hace click en uno de los TextBox, si escribió en otro
         * se borra el contenido
         */
        private void CondicionJvsPC_MouseClick(TextBox txtBox)
        {
            //if (txtBox == textBoxR)
            //{
            //    textBoxV.Text = "";
            //    textBoxA.Text = "";
            //    textBoxC.Text = "";
            //}
            //if (txtBox == textBoxV)
            //{
            //    textBoxR.Text = "";
            //    textBoxA.Text = "";
            //    textBoxC.Text = "";
            //}
            //if (txtBox == textBoxA)
            //{
            //    textBoxR.Text = "";
            //    textBoxV.Text = "";
            //    textBoxC.Text = "";
            //}
            //if (txtBox == textBoxC)
            //{
            //    textBoxR.Text = "";
            //    textBoxV.Text = "";
            //    textBoxA.Text = "";
            //}
        }

        /*
         * En JvsJ mientras el mouse se mueva en un determinado TextBox,
         * solo deja habilitado el color que se encuentra dispuesto en
         * diagnonal en el tablero, para que no haya ventaja
         */
        private void CondicionJvsJ_MouseMove(TextBox txtBox)
        {
            if (txtBox == textBoxR)
            {
                textBoxV.Enabled = false;
                textBoxA.Enabled = true;
                textBoxC.Enabled = false;
            }
            if (txtBox == textBoxV)
            {
                textBoxR.Enabled = false;
                textBoxA.Enabled = false;
                textBoxC.Enabled = true;
            }
            if (txtBox == textBoxA)
            {
                textBoxR.Enabled = true;
                textBoxV.Enabled = false;
                textBoxC.Enabled = false;
            }
            if (txtBox == textBoxC)
            {
                textBoxR.Enabled = false;
                textBoxV.Enabled = true;
                textBoxA.Enabled = false;
            }
        }

        /*
         * Si uno de los jugadores hace click en determinado TextBox,
         * esta funcion limpia los TextBox escritos anteriormente y que
         * no corresponda a una posibilidad de juego entre los colores
         */
        private void CondicionJvsJ_MouseClick(TextBox txtBox)
        {
            if (txtBox == textBoxR)
            {
                textBoxV.Text = "";
                textBoxC.Text = "";
            }
            if (txtBox == textBoxV)
            {
                textBoxR.Text = "";
                textBoxA.Text = "";
            }
            if (txtBox == textBoxA)
            {
                textBoxV.Text = "";
                textBoxC.Text = "";
            }
            if (txtBox == textBoxC)
            {
                textBoxR.Text = "";
                textBoxA.Text = "";
            }
        }

        private void FormularioSC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cerrado = true;
            LimpiarTextBox();
            ReiniciarTextBox();
        }

        private void labelSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxR_Click(object sender, EventArgs e)
        {
        }

        private void labelRojo_Click(object sender, EventArgs e)
        {
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxV_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
