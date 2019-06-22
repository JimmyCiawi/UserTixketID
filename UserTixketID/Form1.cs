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
    public struct User
    {
        public static string ID;
        public static string nama;
        public static string kata_kunci;
    }
    public partial class Form1 : Form
    {
        private static readonly Form1 INSTANCE = new Form1();
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 Instance
        {
            get
            {
                return INSTANCE;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            daftar1.BringToFrontCustom(() => { daftar1.loginAction = () => login1.BringToFrontCustom(); });
            login1.BringToFrontCustom(() => { login1.daftarAction = () => daftar1.BringToFrontCustom(); });
        }
    }
}
