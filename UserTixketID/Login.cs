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
    public partial class Login : UserControl
    {
        private string idPengguna;
        private string kataSandiPengguna;

        [Category("Custom Property")]
        public string Id { get { return idPengguna; } set { idPengguna = value; idText.Text = value; } }
        [Category("Custom Property")]
        public string KataSandi { get { return kataSandiPengguna; } set { kataSandiPengguna = value; kataSandiText.Text = value; } }
        public Login()
        {
            InitializeComponent();
        }
    }
}
