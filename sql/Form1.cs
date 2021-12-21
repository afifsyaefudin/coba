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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
    MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kantinamikom");
    
        private void resetData()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtVoucher.Text = "";
        }
        private void showData()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "customer");
            dgvCostumer.DataSource = ds;
            dgvCostumer.DataMember = "customer";
            dgvCostumer.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resetData();
            showData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from costumer where namaCustomer like '%" + txtCari.Text + "%'";
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "costumer");
            dgvCostumer.DataSource = ds;
            dgvCostumer.DataMember = "costumer";
            dgvCostumer.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtVoucher.Text == "")
            {
                MessageBox.Show("Semua Data harus di isi", "Warning");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtVoucher.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Warning");
                goto berhenti;
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customer values('" + txtId.Text + "','" + txtNama.Text + "',"
                + int.Parse(txtVoucher.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            showData();
            resetData();

        berhenti:
            ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" | txtNama.Text == "" | txtVoucher.Text == "")
            {
                MessageBox.Show("Semua Data harus di isi", "Warning");
                goto berhenti;
            }
            int num;
            bool isNum = int.TryParse(txtVoucher.Text.ToString(), out num);
            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Warning");
                goto berhenti;
            }
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update customer set namaCustomer = '" + txtNama.Text + "', nominalIsi=" +
                txtVoucher.Text + " where idCustomer = '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showData();
            resetData();

        berhenti:
            ;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Apakah anda yakin untuk menghapus data ini ?", "pilihan", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Isi ID costumer yang akan dihapus !!");
                    txtId.Focus();
                    goto berhenti;
                }
                else
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from customer where idCustomer = '" + txtId.Text + "'";
                    cmd.ExecuteNonQuery(); 
                }
                con.Close();
                showData();
                resetData();
            berhenti:
                ;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.Show();
            Hide();
        }
    }
}
