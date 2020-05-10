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
using System.Security.Permissions;
using System.Configuration;
using System.Runtime.InteropServices;

namespace BankingApp
{
    public partial class Mainmenu : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dwbid\OneDrive\Documents\bankLogin.mdf;Integrated Security=True;Connect Timeout=30");
        public Mainmenu(string email)
        {
            InitializeComponent();
            emailLabel.Text = email;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            con.Open();
            String query = "Select Name, Amount, Address, Card From tblBank Where Email = '" + emailLabel.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nameLabel.Text = reader["Name"].ToString();
                amountBox.Text = reader["Amount"].ToString();
                addressLabel.Text = reader["Address"].ToString();
                accountLabel.Text = reader["Card"].ToString();



            }
            con.Close();



        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void amountLabel(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            con.Open();

            int amount;
            int.TryParse(amountBox.Text, out amount);


            int deposit;
            int.TryParse(cashText.Text, out deposit);
            if (deposit == 0)
            {
                MessageBox.Show("Enter a numeric value greater than 0");
                con.Close();
            }
            else
            {
                int total = amount + deposit;




                string query = "UPDATE tblBank SET Amount = '" + total + "'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("$" + deposit + " was deposited");

                String query2 = "Select Amount From tblBank Where Email = '" + emailLabel.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader reader = cmd2.ExecuteReader();



                while (reader.Read())
                {
                    amountBox.Text = "" + Convert.ToInt32(reader["Amount"]);
                }

                con.Close();

            }




















        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            con.Open();
            int amount;

            
            int.TryParse(amountBox.Text, out amount);


            int withdraw;
            int.TryParse(cashText.Text, out withdraw);
            if (withdraw == 0)
            {
                MessageBox.Show("Enter a numeric value greater than 0");
                con.Close();
            }
            else
            {
                int total = amount - withdraw;
                if (total < 0)
                {
                    MessageBox.Show("Insufficient Funds");
                    con.Close();
                }
                else
                {


                    string query = "UPDATE tblBank SET Amount = '" + total + "'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("$" + withdraw + " was withdrew");

                    String query2 = "Select Amount From tblBank Where Email = '" + emailLabel.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    SqlDataReader reader = cmd2.ExecuteReader();



                    while (reader.Read())
                    {
                        amountBox.Text = "" + Convert.ToInt32(reader["Amount"]);
                    }

                    con.Close();

                }



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query3 = "Select Amount From tblBank Where Email = '" + emailLabel.Text + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader reader3 = cmd3.ExecuteReader();



            while (reader3.Read())
            {
                amountBox.Text = "" + Convert.ToInt32(reader3["Amount"]);
            }
            con.Close();
        }
    }
}

