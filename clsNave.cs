using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySosaNahuel
{
    internal class clsNave
    {
        //caracteristicas o propiedades

        public int vida;
        public string nombre;
        int daño;
        public PictureBox imgNave;

        //Creamos un procedimiento llamado "crearJugador"
        public void crearJugador() //void viene de vacio
        {
            vida = 100;
            nombre = "Player 1";
            daño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            //imgNave.ImageLocation = "|DataDirectory|\\Resources\\Nave Galaga Recorte.png";
            imgNave.ImageLocation = "C:\\Users\\nnahu\\OneDrive\\Escritorio\\2do Año Sist\\Lab Prog III\\prySosaNahuel\\Resources\\Nave Galaga Recorte.png";

        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Enemy 1";
            daño = 2;
        }

    }
}
