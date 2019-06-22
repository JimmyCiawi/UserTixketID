namespace UserTixketID
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daftar1 = new UserTixketID.Daftar();
            this.login1 = new UserTixketID.Login();
            this.daftarFilm1 = new UserTixketID.DaftarFilm();
            this.SuspendLayout();
            // 
            // daftar1
            // 
            this.daftar1.Id = "";
            this.daftar1.KataSandi = "";
            this.daftar1.Location = new System.Drawing.Point(12, 12);
            this.daftar1.Lokasi = "";
            this.daftar1.Nama = "";
            this.daftar1.Name = "daftar1";
            this.daftar1.Size = new System.Drawing.Size(1048, 518);
            this.daftar1.TabIndex = 0;
            // 
            // login1
            // 
            this.login1.Id = "";
            this.login1.KataSandi = "";
            this.login1.Location = new System.Drawing.Point(12, 12);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1048, 518);
            this.login1.TabIndex = 1;
            // 
            // daftarFilm1
            // 
            this.daftarFilm1.Location = new System.Drawing.Point(12, 12);
            this.daftarFilm1.Name = "daftarFilm1";
            this.daftarFilm1.Size = new System.Drawing.Size(1048, 518);
            this.daftarFilm1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 542);
            this.Controls.Add(this.daftarFilm1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.daftar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        public Daftar daftar1;
        public Login login1;
        public DaftarFilm daftarFilm1;

    }
}

