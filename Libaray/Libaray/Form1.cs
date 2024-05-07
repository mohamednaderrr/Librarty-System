using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Libaray
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
          string strconnection ="data source=MOHAMED-NADER;Initial Catalog = Libraryy; Integrated Security = true";
            con = new SqlConnection(strconnection);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = textBox2.Text;
                SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Dashboard d = new Dashboard();
                d.Show();
               
            }
            else
            {
                MessageBox.Show("Login Failed");

            }
                con.Close();
            }
        }
    }

