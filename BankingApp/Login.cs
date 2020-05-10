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

namespace BankingApp
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dwbid\OneDrive\Documents\bankLogin.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
            if (emailText.Text != "Username")
            { 

                emailText.ForeColor = Color.Black;
            }
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select Email, Password From tblBank Where Email = '" + emailText.Text.Trim() + "' and Password = '" + passText.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Mainmenu menu = new Mainmenu(emailText.Text);
                this.Hide();
                menu.Show();
                con.Close();
                
                
            }
            else
            {
                MessageBox.Show("Incorrect email and/or password entered");
                con.Close();
            }

        }
    }
}
