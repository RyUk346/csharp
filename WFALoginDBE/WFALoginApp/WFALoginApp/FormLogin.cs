using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFALoginApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=RYUK\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Persist Security Info=True;User ID=cs;Password=181298");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from User_table;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            string data = ds.Tables[0].Rows[0][1].ToString();
            MessageBox.Show(data);

            sqlcon.Close();
        }
    }
}
