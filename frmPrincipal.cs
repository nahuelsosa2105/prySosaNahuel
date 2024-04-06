using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace prySosaNahuel
{
    public partial class frmPrincipal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
            
        }

        

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirma pasarFirma = new frmFirma();
            pasarFirma.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerJuego_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJuego pasarJuego = new frmJuego();
            pasarJuego.Show();
        }
    }
}
