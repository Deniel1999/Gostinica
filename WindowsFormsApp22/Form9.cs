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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
               new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "Select * from sotrudniki where id="
                + Program.id_user;
            SqlCommand comm = new SqlCommand(s, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            string ss = read.GetString(10).Trim();
            if (ss != textBox1.Text.Trim())
            {
                MessageBox.Show("Старый пароль не верный!");
            }
            else
            {
                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                {
                    MessageBox.Show("Пароли не совпадают");
                }
                else
                {
                    read.Close();
                    conn.Close();
                    conn.Open();
                    string sss = "update sotrudniki set " +
                    "password='" + textBox2.Text.Trim() + "' " +
                    "where id = " + Program.id_user.ToString();
                    SqlCommand comm2 = new SqlCommand(sss, conn);
                    comm2.ExecuteScalar();
                    MessageBox.Show("Пароль изменён!");
                    this.Close();
                }
            }
        }
    }
}
