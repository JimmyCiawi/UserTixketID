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
        public int harga { get { return int.Parse(hargaText.Text); } set { hargaText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public int durasi { get { return int.Parse(durasiText.Text); } set { durasiText.Text = value.ToString(); } }
        [Category("Custom Property")]
        public string jadwal { get { return jadwalText.Text; } set { jadwalText.Text = value; } }
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
            idFilm = id_film;
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
                jadwal = ((DateTime)reader["jadwal_tayang"]).ToString("dddd MMMM dd,yyyy      HH:mm");
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

        private void beliButton_Click(object sender, EventArgs e)
        {
            int jumlahTkt = int.Parse(jumlahTiket.Text);
            int totalHarga = jumlahTkt * harga;
            int uangUser = int.Parse(uangAndaText.Text);
            int kembalian = totalHarga - uangUser;
            string msg = "";
            if (kembalian >= 0)
            {
                msg = string.Format("Apakah Anda yakin membeli {0} tiket\nTotal Harga: {1}\nUang Anda: {2}",
                    jumlahTkt, totalHarga, uangUser);
                if (kembalian > 0) msg += string.Format("\nKembalian: {0}", kembalian);
            }
            else
            {
                msg = "Maaf, Uang Anda Tidak Mencukupi";
                if (MessageBox.Show(msg) == DialogResult.OK) return;
            }
            if (MessageBox.Show(msg, "Pembayaran", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idTiket = (idFilm + DateTime.Now.ToString("MMddyyyyHHmm")).Trim();
                MessageBox.Show("Terbeli!!!\nDengan ID "+idTiket);
            }
        }

        private void MembuatTiket(string idFilm, string idUser)
        {
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO daftar_tiket (id_tiket,id_film,id_pengguna) values (@id_tiket,@id_film,id_pengguna)";
            command.Parameters.AddWithValue("@id_tiket", (idFilm + DateTime.Now.ToString("MMddyyyyHHmm")).Trim());
            command.Parameters.AddWithValue("@id_film", idFilm);
            command.Parameters.AddWithValue("@id_pengguna", User.ID);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data berhasil dimasukkan!!!");
                    Console.WriteLine("{0} row/rows affected", count);
                }
                else
                {
                    MessageBox.Show("Data tidak berhasil diinput, Try Again!!!");
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error Data tidak berhasil diInput\n" + error.Message);
            }
            if (connection.State != ConnectionState.Closed) connection.Close();
        }

        private void jumlahTiket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uangAndaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
