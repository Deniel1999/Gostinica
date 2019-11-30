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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect =
new SqlConnection(Program.st_connect);
            connect.Open();
            string s = "update nomera set " +
            "categoria='" + textBox1.Text.Trim() + "', " +
            "col_mest='" + textBox2.Text.Trim() + "', " +
            "opisanie='" + textBox3.Text.Trim() + "', " +
            "stoimost='" + textBox4.Text.Trim() + "', " +
            "photo='" + label6.Text + "'" +
            "where id = " + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, connect);
            comm.ExecuteScalar();
            connect.Close();
            MessageBox.Show("Изменения сохранены");
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
    }
}
