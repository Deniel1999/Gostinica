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
    public partial class Form2 : Form
    {
        public Form2()
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
                string m = "select * from klienti where login='" + login + "' and password='" + password + "'";
                SqlCommand command = new SqlCommand(m, connect);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Program.id_user = reader.GetInt32(0);
                    SqlConnection conn = new SqlConnection(Program.st_connect);
                    conn.Open();
                    string s = "select * from klienti where id="
                        + Program.id_user.ToString();
                    SqlCommand comm = new SqlCommand(s, conn);
                    SqlDataReader read = comm.ExecuteReader();
                    read.Read();
                    Form12 f = new Form12();
                    f.textBox1.Text = read.GetString(1);
                    f.textBox2.Text = read.GetString(2);
                    f.textBox3.Text = read.GetString(3);
                    f.textBox4.Text = read.GetDateTime(4).ToString();
                    f.textBox5.Text = read.GetString(5);
                    f.comboBox1.Text = read.GetString(6);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }
    }
}
