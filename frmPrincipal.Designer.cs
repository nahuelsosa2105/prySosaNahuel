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
            this.btnVer = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbpNave = new System.Windows.Forms.TabPage();
            this.btnVerJuego = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbPrincipal.SuspendLayout();
            this.tbpFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpNave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tbpInicio.Size = new System.Drawing.Size(953, 440);
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
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(398, 160);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(482, 134);
            this.materialMultiLineTextBox1.TabIndex = 4;
            this.materialMultiLineTextBox1.Text = "En este formulario se realizó una firma virtual a traves del mouse, donde tambien" +
    " se guarda como formato png ";
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::prySosaNahuel.Properties.Resources.Captura_frmFirma;
            this.pictureBox1.Location = new System.Drawing.Point(41, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbpNave
            // 
            this.tbpNave.BackColor = System.Drawing.Color.White;
            this.tbpNave.Controls.Add(this.btnVerJuego);
            this.tbpNave.Controls.Add(this.materialLabel7);
            this.tbpNave.Controls.Add(this.materialLabel8);
            this.tbpNave.Controls.Add(this.materialLabel9);
            this.tbpNave.Controls.Add(this.materialMultiLineTextBox2);
            this.tbpNave.Controls.Add(this.materialLabel10);
            this.tbpNave.Controls.Add(this.materialLabel11);
            this.tbpNave.Controls.Add(this.materialLabel12);
            this.tbpNave.Controls.Add(this.pictureBox2);
            this.tbpNave.ImageKey = "Nave Galaga Recorte.png";
            this.tbpNave.Location = new System.Drawing.Point(4, 39);
            this.tbpNave.Name = "tbpNave";
            this.tbpNave.Size = new System.Drawing.Size(953, 440);
            this.tbpNave.TabIndex = 2;
            this.tbpNave.Text = "Juego tipo \"Galaga\"";
            // 
            // btnVerJuego
            // 
            this.btnVerJuego.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerJuego.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerJuego.Depth = 0;
            this.btnVerJuego.HighEmphasis = true;
            this.btnVerJuego.Icon = null;
            this.btnVerJuego.Location = new System.Drawing.Point(754, 353);
            this.btnVerJuego.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerJuego.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerJuego.Name = "btnVerJuego";
            this.btnVerJuego.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerJuego.Size = new System.Drawing.Size(143, 36);
            this.btnVerJuego.TabIndex = 18;
            this.btnVerJuego.Text = "ver formulario";
            this.btnVerJuego.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerJuego.UseAccentColor = false;
            this.btnVerJuego.UseVisualStyleBackColor = true;
            this.btnVerJuego.Click += new System.EventHandler(this.btnVerJuego_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(556, 95);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(83, 24);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "26/03/24";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(411, 147);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(110, 24);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Descripción:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(411, 95);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(139, 24);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Fecha de inicio:";
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(415, 174);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(482, 134);
            this.materialMultiLineTextBox2.TabIndex = 13;
            this.materialMultiLineTextBox2.Text = resources.GetString("materialMultiLineTextBox2.Text");
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel10.Location = new System.Drawing.Point(474, 43);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(175, 24);
            this.materialLabel10.TabIndex = 12;
            this.materialLabel10.Text = "Juego tipo \"Galaga\"";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel11.Location = new System.Drawing.Point(411, 43);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(57, 24);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Título:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(55, 43);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(89, 19);
            this.materialLabel12.TabIndex = 10;
            this.materialLabel12.Text = "Vista Previa:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(58, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 226);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "firma.png");
            this.imageList1.Images.SetKeyName(1, "Nave Galaga Recorte.png");
            this.imageList1.Images.SetKeyName(2, "inicio.jpg");
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
            this.tbpNave.ResumeLayout(false);
            this.tbpNave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton btnVerJuego;
    }
}

