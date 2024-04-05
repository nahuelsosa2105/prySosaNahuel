namespace prySosaNahuel
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tbPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpInicio = new System.Windows.Forms.TabPage();
            this.tbpFirma = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbpNave = new System.Windows.Forms.TabPage();
            this.tbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.tbpInicio);
            this.tbPrincipal.Controls.Add(this.tbpFirma);
            this.tbPrincipal.Controls.Add(this.tbpNave);
            this.tbPrincipal.Depth = 0;
            this.tbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrincipal.ImageList = this.imageList1;
            this.tbPrincipal.Location = new System.Drawing.Point(3, 64);
            this.tbPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPrincipal.Multiline = true;
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(794, 383);
            this.tbPrincipal.TabIndex = 1;
            // 
            // tbpInicio
            // 
            this.tbpInicio.BackColor = System.Drawing.Color.White;
            this.tbpInicio.ImageKey = "inicio.jpg";
            this.tbpInicio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbpInicio.Location = new System.Drawing.Point(4, 39);
            this.tbpInicio.Name = "tbpInicio";
            this.tbpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInicio.Size = new System.Drawing.Size(786, 340);
            this.tbpInicio.TabIndex = 0;
            this.tbpInicio.Text = "Inicio";
            // 
            // tbpFirma
            // 
            this.tbpFirma.BackColor = System.Drawing.Color.White;
            this.tbpFirma.ImageKey = "firma.png";
            this.tbpFirma.Location = new System.Drawing.Point(4, 39);
            this.tbpFirma.Name = "tbpFirma";
            this.tbpFirma.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFirma.Size = new System.Drawing.Size(786, 340);
            this.tbpFirma.TabIndex = 1;
            this.tbpFirma.Text = "Firma";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "firma.png");
            this.imageList1.Images.SetKeyName(1, "Nave Galaga Recorte.png");
            this.imageList1.Images.SetKeyName(2, "inicio.jpg");
            // 
            // tbpNave
            // 
            this.tbpNave.BackColor = System.Drawing.Color.White;
            this.tbpNave.ImageKey = "Nave Galaga Recorte.png";
            this.tbpNave.Location = new System.Drawing.Point(4, 39);
            this.tbpNave.Name = "tbpNave";
            this.tbpNave.Size = new System.Drawing.Size(786, 340);
            this.tbpNave.TabIndex = 2;
            this.tbpNave.Text = "Juego tipo \"Galaga\"";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.tbPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbPrincipal;
        private System.Windows.Forms.TabPage tbpInicio;
        private System.Windows.Forms.TabPage tbpFirma;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tbpNave;
    }
}

