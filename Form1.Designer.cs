namespace AppTimer
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
            this.components = new System.ComponentModel.Container();
            this.btnActivar = new System.Windows.Forms.Button();
            this.picJordan = new System.Windows.Forms.PictureBox();
            this.picLebron = new System.Windows.Forms.PictureBox();
            this.tmrDesplazar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picJordan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLebron)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(699, 390);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(89, 48);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Desplazar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // picJordan
            // 
            this.picJordan.Image = global::AppTimer.Properties.Resources.imgJordan;
            this.picJordan.Location = new System.Drawing.Point(320, 259);
            this.picJordan.Name = "picJordan";
            this.picJordan.Size = new System.Drawing.Size(149, 125);
            this.picJordan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJordan.TabIndex = 1;
            this.picJordan.TabStop = false;
            // 
            // picLebron
            // 
            this.picLebron.Image = global::AppTimer.Properties.Resources.imgLebron;
            this.picLebron.Location = new System.Drawing.Point(329, 21);
            this.picLebron.Name = "picLebron";
            this.picLebron.Size = new System.Drawing.Size(153, 137);
            this.picLebron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLebron.TabIndex = 0;
            this.picLebron.TabStop = false;
            // 
            // tmrDesplazar
            // 
            this.tmrDesplazar.Tick += new System.EventHandler(this.tmrDesplazar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.picJordan);
            this.Controls.Add(this.picLebron);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picJordan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLebron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLebron;
        private System.Windows.Forms.PictureBox picJordan;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Timer tmrDesplazar;
    }
}

