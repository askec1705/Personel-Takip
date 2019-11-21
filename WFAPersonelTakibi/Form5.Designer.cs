namespace WFAPersonelTakibi
{
    partial class Form5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnList = new MetroFramework.Controls.MetroTile();
            this.btnNewRecord = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFAPersonelTakibi.Properties.Resources.img;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.ActiveControl = null;
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnList.Location = new System.Drawing.Point(270, 269);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(307, 158);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Personel Listesi";
            this.btnList.TileImage = global::WFAPersonelTakibi.Properties.Resources.icons8_user_account_104px;
            this.btnList.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnList.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnList.UseCustomBackColor = true;
            this.btnList.UseSelectable = true;
            this.btnList.UseTileImage = true;
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.ActiveControl = null;
            this.btnNewRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNewRecord.Location = new System.Drawing.Point(23, 269);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(241, 158);
            this.btnNewRecord.TabIndex = 0;
            this.btnNewRecord.Text = "Yeni Kayıt Ekle";
            this.btnNewRecord.TileImage = global::WFAPersonelTakibi.Properties.Resources.icons8_add_user_male_104px_1;
            this.btnNewRecord.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNewRecord.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNewRecord.UseCustomBackColor = true;
            this.btnNewRecord.UseSelectable = true;
            this.btnNewRecord.UseTileImage = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnNewRecord);
            this.Name = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnNewRecord;
        private MetroFramework.Controls.MetroTile btnList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}