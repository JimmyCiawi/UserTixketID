using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserTixketID
{
    public partial class ItemFilm : UserControl
    {
        private string idFilm;
        private string judulFilm;
        private Image coverFilm;

        [Category("Custom Property")]
        public string Id_film { get { return idFilm; } set { idFilm = value; } }
        [Category("Custom Property")]
        public string Judul { get { return judulText.Text; } set { judulText.Text = value; } }
        [Category("Custom Property")]
        public Image Cover { get { return coverImage.Image; } set { coverImage.Image = value; } }

        public ItemFilm()
        {
            InitializeComponent();
        }

        private void itemFilm_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
