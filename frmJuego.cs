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
        clsNave objNaveEnemiga;
        public frmJuego()
        {
            InitializeComponent();
        }

        private List<clsNave> enemigos = new List<clsNave>();

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNavePly = new clsNave();

            objNavePly.crearJugador();

            objNavePly.imgNave.Location = new Point(400,600 );
            Controls.Add(objNavePly.imgNave);

            //objNaveEnemiga = new clsNave();
            //objNaveEnemiga.crearEnemigos();
            //objNaveEnemiga.imgNaveEnemiga.Location = new Point(200, 200);
            //Controls.Add(objNaveEnemiga.imgNaveEnemiga);

            for (int i = 0; i < 5; i++) //Creo un bucle para generar los enemigos
            {
                clsNave objNaveEnemiga = new clsNave();
                objNaveEnemiga.crearEnemigos();

                
                Random numeroRandom = new Random();
                int posicionX;
                bool superpuesto;

                do
                {
                    posicionX = numeroRandom.Next(0, this.ClientSize.Width - objNaveEnemiga.imgNaveEnemiga.Width);
                    superpuesto = false;

                    // Comprobar si la nueva posición se superpone con las posiciones de los enemigos existentes
                    foreach (clsNave enemigoExistente in enemigos)
                    {
                        if (Math.Abs(posicionX - enemigoExistente.imgNaveEnemiga.Location.X) < objNaveEnemiga.imgNaveEnemiga.Width)
                        {
                            superpuesto = true;
                            break;
                        }
                    }
                }
                while (superpuesto);

                // Asignar la posición al enemigo y agregarlo a la lista de enemigos
                objNaveEnemiga.imgNaveEnemiga.Location = new Point(posicionX, 200);
                enemigos.Add(objNaveEnemiga);

                Controls.Add(objNaveEnemiga.imgNaveEnemiga);
            }
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
