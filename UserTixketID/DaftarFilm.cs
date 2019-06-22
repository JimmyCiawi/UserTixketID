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
    public partial class DaftarFilm : UserControl
    {
        public static List<ItemFilm> itemFilmList = new List<ItemFilm>();
        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=bioskop_tixket_id;Uid=root;Pwd=;");
        public DaftarFilm()
        {
            InitializeComponent();
        }

        public void BringToFrontCustom(Action doSomething = null)
        {
            base.BringToFront();
            if (doSomething != null) doSomething();
        }

        public void GenerateItemList()
        {
            itemFilmList.Clear();
            layoutGroup.Controls.Clear();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT id_film,judul,gambar FROM daftar_film";
            var da = new MySqlDataAdapter(command);
            var table = new DataTable();
            da.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ItemFilm item = new ItemFilm();
                //if (!reader.Read()) continue;
                item.Id_film = table.Rows[i][0].ToString();
                item.Judul = table.Rows[i][1].ToString();
                MemoryStream ms = new MemoryStream((byte[])table.Rows[i][2]);
                item.Cover = Image.FromStream(ms);
                itemFilmList.Add(item);
            }
            layoutGroup.Controls.AddRange(itemFilmList.ToArray());
        }
    }
}
