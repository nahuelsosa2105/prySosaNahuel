namespace prySosaNahuel
{
    partial class frmJuego
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
            this.tmrMisil = new System.Windows.Forms.Timer(this.components);
            this.tmrMisilEnemigos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrMisil
            // 
            this.tmrMisil.Interval = 75;
            this.tmrMisil.Tick += new System.EventHandler(this.tmrMisil_Tick);
            // 
            // tmrMisilEnemigos
            // 
            this.tmrMisilEnemigos.Tick += new System.EventHandler(this.tmrMisilEnemigos_Tick);
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySosaNahuel.Properties.Resources.FondoJuego;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJuego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJuego_FormClosed);
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJuego_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer tmrMisil;
        private System.Windows.Forms.Timer tmrMisilEnemigos;
    }
}