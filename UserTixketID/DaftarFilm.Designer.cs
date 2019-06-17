namespace UserTixketID
{
    partial class DaftarFilm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.itemFilm1 = new UserTixketID.ItemFilm();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.itemFilm1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 518);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // itemFilm1
            // 
            this.itemFilm1.Cover = null;
            this.itemFilm1.Judul = null;
            this.itemFilm1.Location = new System.Drawing.Point(13, 13);
            this.itemFilm1.Name = "itemFilm1";
            this.itemFilm1.Size = new System.Drawing.Size(150, 200);
            this.itemFilm1.TabIndex = 1;
            // 
            // DaftarFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DaftarFilm";
            this.Size = new System.Drawing.Size(1048, 518);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ItemFilm itemFilm1;
    }
}
