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
            command.CommandText = "SELECT id_pengguna,kata_sandi FROM pengguna WHERE id_pengguna = @id_pengguna AND kata_sandi = @kata_sandi";
            command.Parameters.AddWithValue("@id_pengguna", Id);
            command.Parameters.AddWithValue("@kata_sandi", KataSandi);

            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                if (!reader.Read()) return;
                MessageBox.Show("reader: "+reader.ToString());
                connection.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("error: " + error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daftarAction();
        }
    }
}
