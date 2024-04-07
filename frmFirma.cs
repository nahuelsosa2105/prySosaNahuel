using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaNahuel
{
    
    public partial class frmFirma : Form
    {
        private Bitmap guardarFirma;
        public frmFirma()
        {
            InitializeComponent();
            pbFirma.MouseDown += pbFirma_MouseDown;
            pbFirma.MouseMove += pbFirma_MouseMove;
            pbFirma.MouseUp += pbFirma_MouseUp;

            guardarFirma = new Bitmap(pbFirma.Width, pbFirma.Height);
            pbFirma.Image = guardarFirma;
        }

        private Point ubicaionPrevia;
        private bool firmando = false;
        private void frmFirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            frmPrincipal volverInicio = new frmPrincipal();
            volverInicio.Show();
        }

        private void pbFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firmando = true;
                ubicaionPrevia = e.Location;

            }
        }

        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (firmando)
            {
                using (Graphics firmita = Graphics.FromImage(guardarFirma))
                {
                    Pen pen = new Pen(Color.Black, 1);
                    firmita.DrawLine(pen, ubicaionPrevia, e.Location);
                }
                pbFirma.Invalidate();
                ubicaionPrevia = e.Location;

            }
           
        }

        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firmando = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFirma();
        }

        private Bitmap firmaGuardada;
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // firmaGuardada = new Bitmap(pbFirma.Width, pbFirma.Height);
           // pbFirma.Image = firmaGuardada;

            if(guardarFirma != null)
            {
                try
                {
                    string carpetaImagenesFirmas = Path.Combine(Application.StartupPath, "Imagenes Firmas");

                    if (!Directory.Exists(carpetaImagenesFirmas))
                    {
                        Directory.CreateDirectory(carpetaImagenesFirmas);
                    }

                    string nombreArchivo = $"firma_{DateTime.Now.ToString("yyyy-MM-dd-HH,mm,ss")}.png";

                    string rutaArchivo = Path.Combine(carpetaImagenesFirmas, nombreArchivo);

                    guardarFirma.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("¡Firma guardada con exito!");

                    LimpiarFirma() ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la firma: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se registro ninguna firma, vuelva a intenrarlo");
            }
        }

        private void LimpiarFirma()
        {
            // Limpiar el bitmap que contiene la firma
            using (Graphics g = Graphics.FromImage(guardarFirma))
            {
                g.Clear(Color.White); // Limpia el bitmap con un fondo blanco
            }

            // Actualizar el PictureBox para mostrar el bitmap limpio
            pbFirma.Invalidate();
        }
    }
}
