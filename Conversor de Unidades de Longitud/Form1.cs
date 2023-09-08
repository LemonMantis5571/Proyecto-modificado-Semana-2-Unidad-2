using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_Unidades_de_Longitud
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdingresar_Click_1(object sender, EventArgs e)
        {
            String enteredUsername = txtusuario.Text;
            String enteredPassword = txtclave.Text;

            UserAuth AuthService = new UserAuth();

            UserClass ValidUser = AuthService.Auth(enteredUsername, enteredPassword);

            if (ValidUser != null)
            {
                new Form2().Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void cmdsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

