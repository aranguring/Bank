using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Lector de base de datos
            try
            {
                StreamReader Inicio = new StreamReader(txtDni.Text);
                //Persona.contrasena = Inicio.ReadLine();
                //Persona.nombre = Inicio.ReadLine();
                if (Inicio.ReadLine() == txtPassword.Text)
                {
                    Persona.contrasena = (txtPassword.Text);
                    MessageBox.Show("Se inició sesión. Bienvenido.");
                    Persona.dni = Inicio.ReadLine();
                    //MessageBox.Show(Inicio.ReadLine());
                    Persona.nombre = Inicio.ReadLine();
                    Persona.dinero = Inicio.ReadLine();
                    //MessageBox.Show(Inicio.ReadLine());
                    Inicio.Close();

                    this.Hide();
                    OpForm pd = new OpForm();
                    pd.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Contraseña o usuario incorrecto. Vuelva a intentar.");
                    txtPassword.Clear();
                }

                //Persona.dni = Inicio.ReadLine();
                //MessageBox.Show(Inicio.ReadLine());
                //Persona.nombre = Inicio.ReadLine();
                //Persona.dinero = Inicio.ReadLine();
                //MessageBox.Show(Inicio.ReadLine());
                //Inicio.Close();

            }
            catch(Exception z)
            {
                MessageBox.Show("Hubo un error en el sistema" + z, "Error");
            }

            //Persona.dni = (txtDni.Text);
            


            //Errores de entrada
            if (string.IsNullOrEmpty(txtDni.Text.Trim()))
            {
                errorProvider1.SetError(txtDni, "Se requiere Usuario");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDni, string.Empty);
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorProvider2.SetError(txtPassword, "Se requiere Contraseña");
                return;
            }
            else
            {
                errorProvider2.SetError(txtPassword, string.Empty);
            }
            this.Hide();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char .IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if(checkMostrar.Checked==true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
