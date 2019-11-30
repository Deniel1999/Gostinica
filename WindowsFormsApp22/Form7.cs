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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
           textBox2.Text.Trim() == "" ||
           textBox3.Text.Trim() == "" ||
           textBox4.Text.Trim() == "" ||
           textBox5.Text.Trim() == "")

            {
                MessageBox.Show("Не все поля заполнены!!");
            }
            else
            {
                SqlConnection conn
                = new SqlConnection(Program.st_connect);
                conn.Open();
                string s1 = "select * from sotrudniki where fam='"
                    + textBox1.Text.Trim() + "'";
                SqlCommand comm1 = new SqlCommand(s1, conn);
                SqlDataReader read1 = comm1.ExecuteReader();
                if (read1.HasRows)
                {

                }
                else
                {
                    conn.Close();
                    conn.Open();



                    string s = "insert into sotrudniki " + "" +
"(fam, im, otch, date_born, dolzhnost, zarplata, type) values " +
"('" + textBox1.Text.Trim() + "'," +
" '" + textBox2.Text.Trim() + "', " +
"'" + textBox3.Text.Trim() + "', " +
"'" + textBox4.Text.Trim() + "', " +
"'" + textBox5.Text.Trim() + "', " +
"'" + textBox6.Text.Trim() + "' , 0)";
                    SqlCommand comm = new SqlCommand(s, conn);
                    comm.ExecuteScalar();
                    this.Close();

                    conn.Close();



                }
            }
        }
    }
}




