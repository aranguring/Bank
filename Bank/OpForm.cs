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
    public partial class OpForm : Form
    {
        public OpForm()
        {
            InitializeComponent();
        }

        private void OpForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Bienvenido(a) " + Persona.nombre + "\nSu saldo actual es:"+Persona.dinero;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtMonto.Text)>3000)
            {
                MessageBox.Show("Solo se admite a hasta S/. 3000");
            }
        }
    }
}
