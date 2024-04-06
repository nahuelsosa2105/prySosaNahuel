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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnVer = new MaterialSkin.Controls.MaterialButton();
            this.tbPrincipal.SuspendLayout();
            this.tbpFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tbPrincipal.Size = new System.Drawing.Size(961, 483);
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
            this.tbpFirma.Controls.Add(this.btnVer);
            this.tbpFirma.Controls.Add(this.materialLabel6);
            this.tbpFirma.Controls.Add(this.materialLabel5);
            this.tbpFirma.Controls.Add(this.materialLabel4);
            this.tbpFirma.Controls.Add(this.materialMultiLineTextBox1);
            this.tbpFirma.Controls.Add(this.materialLabel3);
            this.tbpFirma.Controls.Add(this.materialLabel2);
            this.tbpFirma.Controls.Add(this.materialLabel1);
            this.tbpFirma.Controls.Add(this.pictureBox1);
            this.tbpFirma.ImageKey = "firma.png";
            this.tbpFirma.Location = new System.Drawing.Point(4, 39);
            this.tbpFirma.Name = "tbpFirma";
            this.tbpFirma.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFirma.Size = new System.Drawing.Size(953, 440);
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(38, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Vista Previa:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(394, 29);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Título:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(457, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(116, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Firma Virtual";
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(398, 160);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(482, 134);
            this.materialMultiLineTextBox1.TabIndex = 4;
            this.materialMultiLineTextBox1.Text = "En este formulario se realizó una firma virtual a traves del mouse, donde tambien" +
    " se guarda como formato png ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(394, 81);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(139, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Fecha de inicio:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(394, 133);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(110, 24);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Descripción:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(539, 81);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(83, 24);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "25/03/24";
            // 
            // btnVer
            // 
            this.btnVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVer.Depth = 0;
            this.btnVer.HighEmphasis = true;
            this.btnVer.Icon = null;
            this.btnVer.Location = new System.Drawing.Point(737, 348);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVer.Name = "btnVer";
            this.btnVer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVer.Size = new System.Drawing.Size(143, 36);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "ver formulario";
            this.btnVer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVer.UseAccentColor = false;
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 550);
            this.Controls.Add(this.tbPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.tbPrincipal.ResumeLayout(false);
            this.tbpFirma.ResumeLayout(false);
            this.tbpFirma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbPrincipal;
        private System.Windows.Forms.TabPage tbpInicio;
        private System.Windows.Forms.TabPage tbpFirma;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tbpNave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnVer;
    }
}

