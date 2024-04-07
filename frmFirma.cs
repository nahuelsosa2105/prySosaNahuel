using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaNahuel
{
    
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
            pbFirma.MouseDown += pbFirma_MouseDown;
            pbFirma.MouseMove += pbFirma_MouseMove;
            pbFirma.MouseUp += pbFirma_MouseUp;
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
                using (Graphics firmita = pbFirma.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 1);
                    firmita.DrawLine(pen, ubicaionPrevia, e.Location);
                }
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
            pbFirma.Invalidate();
        }
    }
}
