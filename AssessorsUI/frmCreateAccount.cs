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
    public partial class frmCreateAccount : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=ALOGUINSAN\SQLEXPRESS;Initial Catalog=AssessorsDB;Integrated Security=True");

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("spAccounts_Insert", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("Created successfully.", "Create Information!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (txtUsername.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a username.", "Username!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("Please input a password.", "Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You create an account for Assessor's Application.", "Account Creation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return output;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
