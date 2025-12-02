using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSWORD__Problema_4._5_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttVerificar_Click(object sender, EventArgs e)
        {
            Password P = new Password();

            if (txtContrasenia1.Text == txtContrasenia2.Text)
            {
                if (txtContrasenia1.Text.Length >= P.Longitud)
                {
                    bool confianza = P.EsFuerte(txtContrasenia2.Text);
                    lblEsFuerte.Text = $"Es fuerte?:{confianza}";
                }
                else 
                {
                    MessageBox.Show("La contraseña es muy corta debe tener al menos 8 caracteres");
                }

            }
            else if (txtContrasenia1.Text != txtContrasenia2.Text)
            {
                MessageBox.Show("Ambas contraseñas no son iguales, escriba la misma contraseña en ambos casilleros");
            }


        }

        private void buttContrasenia_Aleatoria_Click(object sender, EventArgs e)
        {
            Password P = new Password();

            P.GenerarPassword();

            txtContraseña_Aleatoria.Text = P.getValor();
        }
    }
}
