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
namespace InventoryManagementSystem
{
    public partial class OrderReady : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U1J2F24\DEV;Initial Catalog=D:\DESKTOP\INVENTORYMANAGEMENTSYSTEM\TUTORIAL DATABASE\DBIMS.MDF;Integrated Security=True");
        SqlDataReader dr ;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adpt;
        public OrderReady()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(
                    "ID жолы бос болмау керек",
                    "Қателік",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else
            {
                string s = textBox1.Text;
                int number = Int32.Parse(s);
                con.Open();
                string query = string.Format("select Ready_rus from tbReady where ID = '{0}'", number);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label3.Text = reader["Ready_rus"].ToString();
                }
                con.Close();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
