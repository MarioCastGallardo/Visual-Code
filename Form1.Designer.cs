namespace Gif.Animado
{
    partial class Form1
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
            this.Gif_Animado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gif_Animado)).BeginInit();
            this.SuspendLayout();
            // 
            // Gif_Animado
            // 
            this.Gif_Animado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Gif_Animado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gif_Animado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Gif_Animado.Image = global::Gif.Animado.Properties.Resources.orange_cat_laughing;
            this.Gif_Animado.Location = new System.Drawing.Point(-7, 0);
            this.Gif_Animado.Name = "Gif_Animado";
            this.Gif_Animado.Size = new System.Drawing.Size(828, 452);
            this.Gif_Animado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gif_Animado.TabIndex = 0;
            this.Gif_Animado.TabStop = false;
            this.Gif_Animado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 451);
            this.Controls.Add(this.Gif_Animado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gif_Animado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Gif_Animado;
    }
}

