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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dwbid\OneDrive\Documents\bankLogin.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            String cmd = "Select * From tblBank Where Email = '" + emailText.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email has already been used");
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO tblBank (Name, Email, Password, Address, Card, PIN) values('" + firstNameText.Text.Trim() + "', '" + emailText.Text.Trim() + "', '" + passText.Text.Trim() + "', '" + addressText.Text.Trim() + "', '" + cardText.Text.Trim() + "', '" + pinText.Text.Trim() + "')", con );
                cmd1.ExecuteNonQuery();
                MessageBox.Show("User Created");
                con.Close();
            }



            

        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
