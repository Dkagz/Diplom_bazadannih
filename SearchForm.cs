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
    public partial class SearchForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U1J2F24\DEV;Initial Catalog=D:\DESKTOP\INVENTORYMANAGEMENTSYSTEM\TUTORIAL DATABASE\DBIMS.MDF;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable td;
        SqlDataAdapter adpt;
        SqlDataReader dr;
        public SearchForm()
        {
            InitializeComponent();
            Display();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
        }
        public void Display()
        {
            con.Open();
            adpt = new SqlDataAdapter("SELECT orderid as 'Тапсырыс ID', odate as 'Тапсырыс күні', O.pid as 'Тауар ID', P.pname as 'Тауар аты', C.cname as 'Сатушы аты', qty as 'Тауар саны', price as 'Тауар бағасы', total as 'Жалпы бағасы', D.Ready_rus as 'Тауар дайындығы'  FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid = C.cid  JOIN tbProduct AS P ON O.pid = P.pid JOIN tbReady as D on orderid = D.ID", con);
            td = new DataTable();
            adpt.Fill(td);
            dataGridView1.DataSource = td;
            con.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public event EventHandler Scroll;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }
        public void searchData(string search)
        {
            con.Open();
            string query = "SELECT orderid as 'Тапсырыс ID', odate as 'Тапсырыс күні', O.pid as 'Тауар ID', P.pname as 'Тауар аты', C.cname as 'Сатушы аты', qty as 'Тауар саны', price as 'Тауар бағасы', total as 'Жалпы бағасы', D.Ready_rus as 'Тауар дайындығы'  FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid = C.cid  JOIN tbProduct AS P ON O.pid = P.pid JOIN tbReady as D on orderid = D.ID where C.cname like N'%" + search+ "%' ";
            adpt = new SqlDataAdapter(query, con);
            td = new DataTable();
            adpt.Fill(td);
            dataGridView1.DataSource = td;
            con.Close();
        }
        public void searchDataByPname(string search)
        {
            con.Open();
            string query = "SELECT orderid as 'Тапсырыс ID', odate as 'Тапсырыс күні', O.pid as 'Тауар ID', P.pname as 'Тауар аты', C.cname as 'Сатушы аты', qty as 'Тауар саны', price as 'Тауар бағасы', total as 'Жалпы бағасы', D.Ready_rus as 'Тауар дайындығы'  FROM tbOrder AS O JOIN tbCustomer AS C ON O.cid = C.cid  JOIN tbProduct AS P ON O.pid = P.pid JOIN tbReady as D on orderid = D.ID where P.pname like N'%" + search + "%' ";
            adpt = new SqlDataAdapter(query, con);
            td = new DataTable();
            adpt.Fill(td);
            dataGridView1.DataSource = td;
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searchDataByPname(textBox2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
