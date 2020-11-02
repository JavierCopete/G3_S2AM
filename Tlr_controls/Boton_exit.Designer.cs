namespace Tlr_controls
{
    partial class Boton_exit
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
            this.SuspendLayout();
            // 
            // Boton_exit
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::Tlr_controls.Properties.Resources.boton_exit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.MistyRose;
            this.Size = new System.Drawing.Size(30, 10);
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
            this.Click += new System.EventHandler(this.Boton_exit_Click);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
