
namespace TLR_EDI
{
    partial class EDI
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEDI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEDI
            // 
            this.btnEDI.Location = new System.Drawing.Point(318, 183);
            this.btnEDI.Name = "btnEDI";
            this.btnEDI.Size = new System.Drawing.Size(131, 74);
            this.btnEDI.TabIndex = 0;
            this.btnEDI.Text = "Tractar EDI";
            this.btnEDI.UseVisualStyleBackColor = true;
            this.btnEDI.Click += new System.EventHandler(this.btnEDI_Click);
            // 
            // EDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEDI);
            this.Name = "EDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEDI;
    }
}

