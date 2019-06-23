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
            this.layoutGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.itemFilm1 = new UserTixketID.ItemFilm();
            this.button1 = new System.Windows.Forms.Button();
            this.layoutGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutGroup
            // 
            this.layoutGroup.Controls.Add(this.itemFilm1);
            this.layoutGroup.Location = new System.Drawing.Point(109, 0);
            this.layoutGroup.Name = "layoutGroup";
            this.layoutGroup.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.layoutGroup.Size = new System.Drawing.Size(889, 518);
            this.layoutGroup.TabIndex = 0;
            // 
            // itemFilm1
            // 
            this.itemFilm1.Cover = null;
            this.itemFilm1.Id_film = null;
            this.itemFilm1.Judul = "";
            this.itemFilm1.Location = new System.Drawing.Point(13, 13);
            this.itemFilm1.Name = "itemFilm1";
            this.itemFilm1.Size = new System.Drawing.Size(150, 200);
            this.itemFilm1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tiket Kamu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DaftarFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layoutGroup);
            this.Name = "DaftarFilm";
            this.Size = new System.Drawing.Size(1048, 518);
            this.layoutGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutGroup;
        private ItemFilm itemFilm1;
        private System.Windows.Forms.Button button1;
    }
}
