using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace UserTixketID
{
    public partial class DetailFilm : UserControl
    {
        public string idFilm;

        [Category("Custom Property")]
        public string judul { get { return judulText.Text; } set { judulText.Text = value; } }
        [Category("Custom Property")]
        public string sinopsis { get { return sinopsisText.Text; } set { sinopsisText.Text = value; } }
        [Category("Custom Property")]
        public string namaBioskop { get { return namaBioskopText.Text; } set { namaBioskopText.Text = value; } }
        [Category("Custom Property")]
        public string lokasiBioskop { get { return lokasiBioskopText.Text; } set { lokasiBioskopText.Text = value; } }
        [Category("Custom Property")]
        public int harga { get { return int.Parse(hargaText.Text); } set { namaBioskopText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public int durasi { get { return int.Parse(durasiText.Text); } set { durasiText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public DateTime jadwal { get { return jadwalTimePicker.Value; } set { jadwalTimePicker.Value = value; } }
        [Category("Custom Property")]
        public Image gambar { get { return gambarBox.Image; } set { gambarBox.Image = value; } }


        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=bioskop_tixket_id;Uid=root;Pwd=;");

        public DetailFilm()
        {
            InitializeComponent();
        }

        public void BringToFrontCustom(Action doSomething = null)
        {
            base.BringToFront();
            if (doSomething != null) doSomething();
        }

        public void MengambilTampilanData(string id_film)
        {
            try
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT id_film,judul,sinopsis,gambar,nama_bioskop,lokasi,harga,jadwal_tayang,durasi_film_menit FROM daftar_film WHERE id_film = @idFilm";
                command.Parameters.AddWithValue("@idFilm", id_film);
                var reader = command.ExecuteReader();
                if (!reader.Read()) return;
                //tambahFilmControl1.IdFilm = reader["id_film"].ToString();
                judul = reader["judul"].ToString();
                sinopsis = reader["sinopsis"].ToString();
                namaBioskop = reader["nama_bioskop"].ToString();
                lokasiBioskop = reader["lokasi"].ToString();
                harga = (int)reader["harga"];
                jadwal = (DateTime)reader["jadwal_tayang"];
                durasi = (int)reader["durasi_film_menit"];
                MemoryStream ms = new MemoryStream((byte[])reader["gambar"]);
                gambar = Image.FromStream(ms);
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            if (connection.State != ConnectionState.Closed) connection.Close();
        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            Form1.Instance.daftarFilm1.BringToFront();
        }
    }
}
