using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UserTixketID
{
    public partial class Login : UserControl
    {
        public Action daftarAction;

        [Category("Custom Property")]
        public string Id { get { return idText.Text; } set { idText.Text = value; } }
        [Category("Custom Property")]
        public string KataSandi { get { return kataSandiText.Text; } set { kataSandiText.Text = value; } }

        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=bioskop_tixket_id;Uid=root;Pwd=;");
        
        public Login()
        {
            InitializeComponent();
        }
        public void BringToFrontCustom(Action doSomething = null)
        {
            base.BringToFront();
            if (doSomething != null) doSomething();
            try
            {
                connection.Open();
                Console.WriteLine("Connection Berhasil dibuka!!!");
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            if (connection.State == ConnectionState.Open) connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT id_pengguna, nama_pengguna, kata_sandi FROM pengguna WHERE id_pengguna = @id_pengguna AND kata_sandi = @kata_sandi";
            command.Parameters.AddWithValue("@id_pengguna", Id);
            command.Parameters.AddWithValue("@kata_sandi", KataSandi);
            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    if (connection.State != ConnectionState.Closed) connection.Close();
                    MessageBox.Show("Maaf, ID atau password Anda salah, mohon diperiksa kembali");
                    return;
                }
                if (!string.IsNullOrEmpty(reader["nama_pengguna"].ToString()))
                {
                    if (MessageBox.Show("Anda login sebagai " + reader["nama_pengguna"].ToString(), "Anda yakin?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        User.ID = reader["id_pengguna"].ToString();
                        User.nama = reader["nama_pengguna"].ToString();
                        User.kata_kunci = reader["kata_sandi"].ToString();
                    }
                    else idText.Focus();
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("error: " + error.Message);
            }
            if (connection.State != ConnectionState.Closed) connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daftarAction();
        }
    }
}
