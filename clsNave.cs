using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
        int dañoGenerado;
        public PictureBox imgProyectil;
        int dañoEnemigo;
        public PictureBox imgProyectilEnemigo;

        //Creamos un procedimiento llamado "crearJugador"
        public void crearJugador() //void viene de vacio
        {
            vida = 100;
            nombre = "Player 1";
            daño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.BackColor = Color.Transparent;
            //imgNave.ImageLocation = "|DataDirectory|\\Resources\\Nave Galaga Recorte.png";
            //imgNave.ImageLocation = (@"../../../../../Resources/Nave Galaga Recorte.png");
            string rutaImagen = Path.Combine(Application.StartupPath,"..","..", "Recursos Juego", "naveSinFondo.png");
            imgNave.ImageLocation = rutaImagen;
            //imgNave.ImageLocation = "https://tienda.factoryarcade.es/2268-thickbox_default/cartel-logo-impresion-3d-nave-galaga.jpg";
            //imgNave.ImageLocation = "https://e7.pngegg.com/pngimages/560/322/png-clipart-brown-and-black-game-item-illustration-space-shooting-spacecraft-sprite-computer-icons-spaceship-game-symmetry-thumbnail.png";
        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Enemy 1";
            daño = 2;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.Width = 90;
            imgNaveEnemiga.Height = 60;
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.BackColor = Color.Transparent;
            string rutaImagen = Path.Combine(Application.StartupPath,"..","..", "Recursos Juego", "naveVerdeEnemiga.png");
            imgNaveEnemiga.ImageLocation = rutaImagen;
            //imgNaveEnemiga.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ826SC8q7wjlVYw_p8BErwOD8ewNe2yEPk64l8_819Tw&s";
        }

        public void Disparar()
        {
            dañoGenerado = 2;
            imgProyectil = new PictureBox();

            imgProyectil.Width = 20;
            imgProyectil.Height = 20;
            //imgProyectil.SizeMode = PictureBoxSizeMode.StretchImage;
            //string rutaImagen = Path.Combine(Application.StartupPath,"..", "..", "Recursos Juego", "misil.png");
            //imgProyectil.ImageLocation = rutaImagen;
            imgProyectil.BackColor = Color.Yellow;
        }

        public void ProyectilEnemigo()
        {
            dañoEnemigo = 10;
            imgProyectilEnemigo = new PictureBox();
            imgProyectilEnemigo.Width = 20;
            imgProyectilEnemigo .Height = 20;
            imgProyectilEnemigo.BackColor = Color.Red;
            imgProyectilEnemigo.Location = new Point(imgNaveEnemiga.Location.X + imgNaveEnemiga.Width/2,imgNaveEnemiga.Location.Y+imgNaveEnemiga.Height);

            Form frm = Application.OpenForms["frmJuego"];
            frm.Controls.Add(imgProyectilEnemigo);

            
        }

    }
}
