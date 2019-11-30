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
using System.IO;

namespace WindowsFormsApp22
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
            textBox2.Text.Trim() == "" ||
            textBox3.Text.Trim() == "" ||
            textBox4.Text.Trim() == "" ||
            textBox6.Text.Trim() == "" ||
            textBox7.Text.Trim() == "" ||
            textBox8.Text.Trim() == "" )


            {
                MessageBox.Show("Не все поля заполнены!!");
            }
            else
            {
                SqlConnection conn
                = new SqlConnection(Program.st_connect);
                conn.Open();
                string s1 = "select * from sotrudniki where login='"
                    + textBox7.Text.Trim() + "'";
                SqlCommand comm1 = new SqlCommand(s1, conn);
                SqlDataReader read1 = comm1.ExecuteReader();
                if (read1.HasRows)
                {
                    MessageBox.Show("Логин занят!!");
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string s = "insert into sotrudniki " + "" +
"(fam, im, otch, date_born, dolzhnost, zarplata, type, login, password) values " +
"('" + textBox1.Text.Trim() + "'," +
" '" + textBox2.Text.Trim() + "', " +
"'" + textBox3.Text.Trim() + "', " +
"'" + textBox4.Text.Trim() + "', 'Администратор' ," +
"'" + textBox6.Text.Trim() + "', 1," +
"'" + textBox7.Text.Trim() + "', " +
"'" + textBox8.Text.Trim() + "') ";
                    SqlCommand comm = new SqlCommand(s, conn);
                    comm.ExecuteScalar();
                    this.Close();
                }
                conn.Close();

            }
        }
    }
}
