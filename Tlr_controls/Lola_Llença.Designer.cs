namespace Tlr_controls
{
    partial class Lola_Llença
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lola)).BeginInit();
            this.SuspendLayout();
            // 
            // Lola
            // 
            this.Lola.BackColor = System.Drawing.Color.Transparent;
            this.Lola.BackgroundImage = global::Tlr_controls.Properties.Resources.logo;
            this.Lola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lola.Location = new System.Drawing.Point(2, 0);
            this.Lola.Name = "Lola";
            this.Lola.Size = new System.Drawing.Size(90, 91);
            this.Lola.TabIndex = 0;
            this.Lola.TabStop = false;
            // 
            // Lola_Llença
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lola);
            this.Name = "Lola_Llença";
            this.Size = new System.Drawing.Size(92, 91);
            ((System.ComponentModel.ISupportInitialize)(this.Lola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Lola;
    }
}
