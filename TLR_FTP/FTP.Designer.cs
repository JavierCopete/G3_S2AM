
namespace TLR_FTP
{
    partial class FTP
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
            this.Cargar = new System.Windows.Forms.Button();
            this.Descargar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.DarkGray;
            this.Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar.Location = new System.Drawing.Point(241, 559);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(310, 185);
            this.Cargar.TabIndex = 0;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = false;
            this.Cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Descargar
            // 
            this.Descargar.BackColor = System.Drawing.Color.DarkGray;
            this.Descargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descargar.Location = new System.Drawing.Point(1030, 559);
            this.Descargar.Name = "Descargar";
            this.Descargar.Size = new System.Drawing.Size(310, 185);
            this.Descargar.TabIndex = 1;
            this.Descargar.Text = "Descargar";
            this.Descargar.UseVisualStyleBackColor = false;
            this.Descargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TLR_FTP.Properties.Resources.Download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1020, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 292);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Transparent;
            this.Upload.BackgroundImage = global::TLR_FTP.Properties.Resources.Upload;
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload.Location = new System.Drawing.Point(228, 171);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(337, 292);
            this.Upload.TabIndex = 2;
            this.Upload.TabStop = false;
            // 
            // FTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 944);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Descargar);
            this.Controls.Add(this.Cargar);
            this.Name = "FTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Descargar;
        private System.Windows.Forms.PictureBox Upload;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}