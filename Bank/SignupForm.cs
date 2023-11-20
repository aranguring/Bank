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

namespace Bank
{
    public partial class SignupForm : Form
    {
        private ControladorPersona cp;
        private Persona perso;
        public SignupForm()
        {
            InitializeComponent(); 
            cp = new ControladorPersona();
            perso = new Persona();
        }
        //Botón de crear nueva cuenta = button1
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer1;
            writer1 = File.CreateText(txtDni.Text);
            string password = txtPassword.Text;
            writer1.WriteLine(password); 
            string dni = txtDni.Text;
            writer1.WriteLine(dni);
            string name = txtUser.Text;
            writer1.WriteLine(name);
            string money = "0";
            writer1.WriteLine(money);
            writer1.Close();
            MessageBox.Show("Su cuenta ha sido creada. Proceda a Iniciar Sesión para su primer depósito.");

            //Persona persona = new Persona();
            //persona.Dni = txtDni.Text;
            //persona.Nombre = txtUser.Text;
            //persona.Contrasena = txtPassword.Text;
            //persona.Dinero = 0;

            //perso = persona;
            //cp.adicionarPersona(persona);

            this.Close();
            Application.Exit();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Length>8)
            {
                MessageBox.Show("Solo 8 caracteres permitidos.");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        //Boton Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
         
            
        }
    }
} 
