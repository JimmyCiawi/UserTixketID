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
        private string judulFilm;
        private Image coverFilm;

        [Category("Custom Property")]
        public string Judul { get { return judulFilm; } set { judulFilm = value; judulText.Text = value; } }
        [Category("Custom Property")]
        public Image Cover { get { return coverFilm; } set { coverFilm = value; coverImage.Image = value; } }

        public ItemFilm()
        {
            InitializeComponent();
        }
    }
}
