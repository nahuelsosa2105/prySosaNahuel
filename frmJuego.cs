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
    public partial class frmJuego : Form
    {
        //Zona de declaracion de variables globales

        clsNave objNavePly; //todavia no esta creado en la memoria, para que se cree en memoria sucede se lo instancia mas abajo en procedimiento "Form Load"
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNavePly = new clsNave();

            objNavePly.crearJugador();

            Controls.Add(objNavePly.imgNave);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            //Procedimiento para que la nave se mueva a la derecha
            if(e.KeyCode == Keys.D)
            {
                objNavePly.imgNave.Location = new Point(objNavePly.imgNave.Location.X + 10, objNavePly.imgNave.Location.Y);
            }

            //Procedimiento para que la nave se mueva a la izquierda

            if (e.KeyCode == Keys.A)
            {
                objNavePly.imgNave.Location = new Point(objNavePly.imgNave.Location.X - 10, objNavePly.imgNave.Location.Y);
            }
        }
    }
}
