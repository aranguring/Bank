using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm pd = new SignupForm();
            pd.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm pd = new LoginForm();
            pd.ShowDialog();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
