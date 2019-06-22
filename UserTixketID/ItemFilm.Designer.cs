namespace UserTixketID
{
    partial class ItemFilm
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
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.judulText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coverImage
            // 
            this.coverImage.Location = new System.Drawing.Point(0, 0);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(150, 150);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 0;
            this.coverImage.TabStop = false;
            this.coverImage.DoubleClick += new System.EventHandler(this.itemFilm_DoubleClick);
            // 
            // judulText
            // 
            this.judulText.Enabled = false;
            this.judulText.Location = new System.Drawing.Point(0, 148);
            this.judulText.Multiline = true;
            this.judulText.Name = "judulText";
            this.judulText.Size = new System.Drawing.Size(150, 52);
            this.judulText.TabIndex = 1;
            this.judulText.DoubleClick += new System.EventHandler(this.itemFilm_DoubleClick);
            // 
            // ItemFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.judulText);
            this.Controls.Add(this.coverImage);
            this.Name = "ItemFilm";
            this.Size = new System.Drawing.Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.TextBox judulText;
    }
}
