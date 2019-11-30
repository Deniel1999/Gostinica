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

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (login == "" || password == "")
            {
                MessageBox.Show("Вы не ввели данные для входа");
            }
            else
            {
                SqlConnection connect = new SqlConnection(Program.st_connect);
                connect.Open();
                string m = "select * from sotrudniki where login='" + login + "' and password='" + password + "'";
                SqlCommand command = new SqlCommand(m, connect);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Program.id_user = reader.GetInt32(0);
                    Program.type_user = reader.GetBoolean(8);
                    if (Program.type_user == true)
                    {
                        Form6 f = new Form6();
                        f.Show();
                        this.Hide();

                    }
                    
                    {
                       
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
                connect.Close();





            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    



