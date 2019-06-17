using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserTixketID
{
    public partial class Daftar : UserControl
    {
        private string idPengguna;
        private string namaPengguna;
        private string kataSandiPengguna;

        [Category("Custom Property")]
        public string Id { get { return idPengguna; } set { idPengguna = value; idText.Text = value; } }
        [Category("Custom Property")]
        public string Nama { get { return namaPengguna; } set { namaPengguna = value; namaText.Text = value; } }
        [Category("Custom Property")]
        public string KataSandi { get { return kataSandiPengguna; } set { kataSandiPengguna = value; kataSandiText.Text = value; } }

        public Daftar()
        {
            InitializeComponent();
        }
    }
}
