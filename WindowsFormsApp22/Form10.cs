﻿using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "" ||
                textBox3.Text.Trim() == "" ||
                textBox4.Text.Trim() == "")



                {
                    MessageBox.Show("Не все поля заполнены!!");
                }
                else
                {
                    SqlConnection conn
                    = new SqlConnection(Program.st_connect);
                    conn.Open();


                    string s = "insert into nomera " + "" +
"(categoria, col_mest, opisanie, stoimost) values " +
"('" + textBox1.Text.Trim() + "'," +
" '" + textBox2.Text.Trim() + "', " +
"'" + textBox3.Text.Trim() + "', " +
"'" + textBox4.Text.Trim() + "') ";
                    SqlCommand comm = new SqlCommand(s, conn);
                    comm.ExecuteScalar();
                    MessageBox.Show("Изменения сохранены"); 
                }
                
            }
        }
    }
}
