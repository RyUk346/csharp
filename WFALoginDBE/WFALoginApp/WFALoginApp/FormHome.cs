using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFALoginApp
{
    public partial class FormHome : Form
    {
        private FormLogin Fl { get; set; }
        public FormHome()
        {
            InitializeComponent();
        }

        public FormHome(FormLogin fl, string text) : this()
        {
            this.Fl = fl;
            this.lblUserInfo.Text += text;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Confirmed.");
            this.Fl.Show();
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
