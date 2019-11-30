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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect =
new SqlConnection(Program.st_connect);
            connect.Open();
            string s = "update klienti set " +
            "fam='" + textBox1.Text.Trim() + "', " +
            "im='" + textBox2.Text.Trim() + "', " +
            "otch='" + textBox3.Text.Trim() + "', " +
            "date_born='" + textBox4.Text.Trim() + "', " +
            "pol='" + textBox5.Text.Trim() + "', " +
            "zacelen='" + comboBox1.SelectedItem.ToString() + "'" +
            "where id = " + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, connect);
            comm.ExecuteScalar();
            connect.Close();
            MessageBox.Show("Изменения сохранены");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k = textBox1.Text;
            string m = textBox2.Text;
            string o = textBox3.Text;
            Form14 f = new Form14();
            f.textBox1.Text = k;
            f.textBox2.Text = m;
            f.textBox3.Text = o;
            f.Show();
        }
    }
}
