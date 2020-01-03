using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssessorsUI
{
    public partial class frmLogin : Form
    {       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ALOGUINSAN\SQLEXPRESS;Initial Catalog=AssessorsDB;Integrated Security=True"))
            {
                string query = "Select * From Accounts Where Username = '" + txtUsername.Text.Trim() + "' And Password = '" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    frmWelcome frm = new frmWelcome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password!", "Login Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword frm = new frmPassword();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
