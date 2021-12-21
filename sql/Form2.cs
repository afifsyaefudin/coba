using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace sql
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kantinamikom");
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        private void resetdata()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
        }

        private void bindingdata()
        {
            dt.Clear();
            txtId.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            txtHarga.DataBindings.Clear();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from menu", con);
            MySqlCommandBuilder scb = new MySqlCommandBuilder(da);

            da.Fill(dt);
            bs.DataSource = dt;
            dgvMenu.DataSource = bs;

            txtId.DataBindings.Add("Text", bs, "idMenu");
            txtNama.DataBindings.Add("Text", bs, "namaMenu");
            txtHarga.DataBindings.Add("Text", bs, "harga");
        }

        private void showdata()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "select * from menu";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "menu");
            dgvMenu.DataSource = ds;
            dgvMenu.DataMember = "menu";
            dgvMenu.ReadOnly = true;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
            bindingdata();
        }

        private void Cari_Click(object sender, EventArgs e)
        {
            bs.Filter = "namaMenu like '%" + txtCari.Text + "%'";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            showdata();
            resetdata();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            resetdata();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtHarga.Text == "")
            {
                MessageBox.Show("Semua Data harus di isi", "Warning");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtHarga.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Isi harga harus angka", "Warning");
                goto berhenti;
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into menu values('" + txtId.Text + "','" + txtNama.Text + "',"
                + int.Parse(txtHarga.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtHarga.Text == "")
            {
                MessageBox.Show("Semua Data harus di isi", "Warning");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtHarga.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Isi Harga harus angka", "Warning");
                goto berhenti;
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update menu set namaMenu = '" + txtNama.Text + "',harga=" +
                int.Parse(txtHarga.Text) + " where idMenu='" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Isi ID costumer yang akan dihapus !!");
                goto berhenti;
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from menu where harga = '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            berhenti:
            ;
        }
    }
}
