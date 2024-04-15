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
        clsNave objMisil;
        clsNave objMisilEmg;

        //Int32 posicionNave;
        Point posicionNave;
        public frmJuego()
        {
            InitializeComponent();
        }

        private List<clsNave> enemigos = new List<clsNave>();

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNavePly = new clsNave();

            objNavePly.crearJugador();

            objMisil = new clsNave();
            objMisil.Disparar();

            objNavePly.imgNave.Location = new Point(400,600 );
            posicionNave = objNavePly.imgNave.Location;
            Controls.Add(objNavePly.imgNave);

            objMisilEmg = new clsNave();
            objMisilEmg.ProyectilEnemigo();


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
                //posicionNave = Convert.ToInt32(objNavePly.imgNave.Location.X);
                posicionNave = objNavePly.imgNave.Location;
            }

            //Procedimiento para que la nave se mueva a la izquierda

            if (e.KeyCode == Keys.A)
            {
                objNavePly.imgNave.Location = new Point(objNavePly.imgNave.Location.X - 10, objNavePly.imgNave.Location.Y);
            }

            //Procedimiento para disparar cada vez que presiono el espacio

            if(e.KeyCode == Keys.Space)
            {
                tmrMisil.Start();
                tmrMisil.Enabled = true;
                //objMisil.imgProyectil.Location = new Point(posicionNave, 600);
                objMisil.imgProyectil.Location = posicionNave;
                Controls.Add(objMisil.imgProyectil);
                
            }
        }

        private void frmJuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal volverInicio = new frmPrincipal();
            volverInicio.Show();
        }

        public void tmrMisil_Tick(object sender, EventArgs e)
        {
            if(objMisil.imgProyectil.Location.Y <= 0)
            {
                tmrMisil.Enabled = false;
                //posicionNave = Convert.ToInt32(objNavePly.imgNave.Location.X);
                posicionNave = objNavePly.imgNave.Location;
                
            }
            else
            {
                objMisil.imgProyectil.Location = new Point(objMisil.imgProyectil.Location.X, objMisil.imgProyectil.Location.Y - 100);
            }
           

        }

        private void tmrMisilEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (clsNave enemigo in enemigos)
            {
                enemigo.ProyectilEnemigo();
            }
        }
    }
}
