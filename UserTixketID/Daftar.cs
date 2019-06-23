using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UserTixketID
{
    public partial class Daftar : UserControl
    {
        public Action loginAction;

        [Category("Custom Property")]
        public string Id { get { return idText.Text; } set { idText.Text = value; } }
        [Category("Custom Property")]
        public string Nama { get { return namaText.Text; } set { namaText.Text = value; } }
        [Category("Custom Property")]
        public string KataSandi { get { return kataSandiText.Text; } set { kataSandiText.Text = value; } }
        [Category("Custom Property")]
        public string Lokasi { get { return lokasiText.Text; } set { lokasiText.Text = value; } }

        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=bioskop_tixket_id;Uid=root;Pwd=;");
        
        public Daftar()
        {
            InitializeComponent();
        }

        public void BringToFrontCustom(Action doSomething = null)
        {
            base.BringToFront();
            if (doSomething != null) doSomething();
        }

        private void Daftar_Load(object sender, EventArgs e)
        {
            kataSandiText.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO pengguna values (@id_pengguna,@kata_sandi,@nama_pengguna,@lokasi)";
            command.Parameters.AddWithValue("@id_pengguna", Id);
            command.Parameters.AddWithValue("@kata_sandi", KataSandi);
            command.Parameters.AddWithValue("@nama_pengguna", Nama);
            command.Parameters.AddWithValue("@lokasi", Lokasi);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) MessageBox.Show("Berhasil Terdaftar!!!");
            }
            catch (MySqlException error)
            {
                string pesan = "";
                if (error.Message.ToLower().Contains("duplicate") && error.Message.ToLower().Contains("primary"))
                    pesan = "ID sudah tersedia, gunakan ID yang lain.";
                else
                    pesan = "error: " + error.Message;
                MessageBox.Show(pesan);
            }
            if (connection.State != ConnectionState.Closed)
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginAction();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            kataSandiText.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
