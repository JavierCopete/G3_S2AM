namespace TLR_Forms
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_Min1 = new Tlr_controls.Boton_Min(this.components);
            this.boton_exit1 = new Tlr_controls.Boton_exit(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.boton_Min1);
            this.panel1.Controls.Add(this.boton_exit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // boton_Min1
            // 
            this.boton_Min1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_Min1.BackColor = System.Drawing.Color.MistyRose;
            this.boton_Min1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boton_Min1.BackgroundImage")));
            this.boton_Min1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Min1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Min1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Min1.ForeColor = System.Drawing.Color.MistyRose;
            this.boton_Min1.Location = new System.Drawing.Point(937, 0);
            this.boton_Min1.Name = "boton_Min1";
            this.boton_Min1.Size = new System.Drawing.Size(39, 35);
            this.boton_Min1.TabIndex = 1;
            this.boton_Min1.UseVisualStyleBackColor = false;
            // 
            // boton_exit1
            // 
            this.boton_exit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boton_exit1.BackColor = System.Drawing.Color.MistyRose;
            this.boton_exit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boton_exit1.BackgroundImage")));
            this.boton_exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_exit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_exit1.ForeColor = System.Drawing.Color.Transparent;
            this.boton_exit1.Location = new System.Drawing.Point(982, 0);
            this.boton_exit1.Name = "boton_exit1";
            this.boton_exit1.Size = new System.Drawing.Size(44, 35);
            this.boton_exit1.TabIndex = 0;
            this.boton_exit1.TabStop = false;
            this.boton_exit1.UseVisualStyleBackColor = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1026, 675);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Tlr_controls.Boton_exit boton_exit1;
        private Tlr_controls.Boton_Min boton_Min1;
    }
}