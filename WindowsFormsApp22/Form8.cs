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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label6.Text =
                    Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName,
                    AppDomain.CurrentDomain.BaseDirectory + label6.Text, true);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect =
new SqlConnection(Program.st_connect);
            connect.Open();
            string s = "update sotrudniki set " +
            "fam='" + textBox1.Text.Trim() + "', " +
            "im='" + textBox2.Text.Trim() + "', " +
            "otch='" + textBox3.Text.Trim() + "', " +
            "date_born='" + textBox4.Text.Trim() + "', " +
            "dolzhnost='" + textBox5.Text.Trim() + "', " +
            "zarplata='" + textBox6.Text.Trim() + "', " +
            "photo='" + label6.Text + "'" +
            "where id = " + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, connect);
            comm.ExecuteScalar();
            connect.Close();
            MessageBox.Show("Изменения сохранены");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
