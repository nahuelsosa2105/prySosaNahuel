using System;
using System.Collections.Generic;
using System.IO;
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
        public PictureBox imgNaveEnemiga;

        //Creamos un procedimiento llamado "crearJugador"
        public void crearJugador() //void viene de vacio
        {
            vida = 100;
            nombre = "Player 1";
            daño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            //imgNave.ImageLocation = "|DataDirectory|\\Resources\\Nave Galaga Recorte.png";
            //imgNave.ImageLocation = (@"../../../../../Resources/Nave Galaga Recorte.png");
            //string rutaImagen = Path.Combine(Application.StartupPath, "Resources", "Nave Galaga Recorte.png");
            imgNave.ImageLocation = "https://tienda.factoryarcade.es/2268-thickbox_default/cartel-logo-impresion-3d-nave-galaga.jpg";
        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Enemy 1";
            daño = 2;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.Width = 60;
            imgNaveEnemiga.Height = 60;
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes Nave", "naveEnemigaUno.png");
            //imgNaveEnemiga.ImageLocation = rutaImagen;
            imgNaveEnemiga.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ826SC8q7wjlVYw_p8BErwOD8ewNe2yEPk64l8_819Tw&s";
        }

    }
}
