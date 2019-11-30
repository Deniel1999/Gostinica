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
    public partial class Form6 : Form
    {
        int n = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gostinicaDataSet2.klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.gostinicaDataSet2.klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gostinicaDataSet1.nomera". При необходимости она может быть перемещена или удалена.
            this.nomeraTableAdapter.Fill(this.gostinicaDataSet1.nomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gostinicaDataSet.sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.gostinicaDataSet.sotrudniki);

            { SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select id, fam, im, otch, date_born, dolzhnost, zarplata, type, login, password from sotrudniki where type=0 " +
"order by id offset " + n.ToString() + " " +
"rows fetch next 10 rows only";
                
            conn.Close();
        }


    }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "delete from sotrudniki where id="
            + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();

            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select * from sotrudniki where id="
                + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            Form8 f = new Form8();
            f.textBox1.Text = read.GetString(1);
            f.textBox2.Text = read.GetString(2);
            f.textBox3.Text = read.GetString(3);
            f.textBox4.Text = read.GetDateTime(4).ToString();
            f.textBox5.Text = read.GetString(5);
            f.textBox6.Text = read.GetDouble(6).ToString();
            string p = read.GetString(7);
            f.pictureBox1.Load(p);
            f.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int k = dataGridView2.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView2[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select * from nomera where id="
                + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();
            Form11 f = new Form11();
            f.textBox1.Text = read.GetString(1);
            f.textBox2.Text = read.GetInt32(2).ToString();
            f.textBox3.Text = read.GetString(3);
            f.textBox4.Text = read.GetDouble(4).ToString();
            string p = read.GetString(5);
            f.pictureBox1.Load(p);
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "delete from nomera where id="
            + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
        }

       

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int k = dataGridView3.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView3[0, k].Value);
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
            f.comboBox1.SelectedItem = read.GetString(6);
            f.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int k = dataGridView3.CurrentRow.Index;
            Program.id_user = Convert.ToInt32(dataGridView3[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "delete from klienti where id="
            + Program.id_user.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
        }
    }
    }
    
    

