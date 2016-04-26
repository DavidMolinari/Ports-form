using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Gestion_Navire
{
    public partial class Frm_Gestion_Navire : Form
    {
        public Frm_Gestion_Navire()
        {
            List<ToutNavire> ToutNavires = new List<ToutNavire>();
            InitializeComponent();
        }

        private void BtnCreerNavireFret_Click(object sender, EventArgs e)
        {
            int numlloyd = Convert.ToInt32(this.TxTirant.Text);
            string nomNavire = this.TxNomNavire.Text;
            string pavillon = this.TxPavillon.Text;
            int longueur = Convert.ToInt32(this.TxLongueur.Text);
            int largueur = Convert.ToInt32(this.TxLargeur.Text);
            int tirantEau = Convert.ToInt32(this.TxTirant.Text);
            string libelleFret = this.TxLibelleFret.Text;
            int qteFret = Convert.ToInt32(this.TxQuantiteFret.Text);
            int nbFret = Convert.ToInt32(this.TxNumFret.Text);
            NavireFret unNavireFret = new NavireFret(numlloyd, nomNavire, pavillon, longueur, largueur, tirantEau, libelleFret, qteFret, nbFret);
        }

        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
            Port port = new Port(this.TxNomPort.Text);

        }

        private void BtnAffecterPort_Click(object sender, EventArgs e)
        {
            List<ToutNavire> ToutNavires = new List<ToutNavire>();
        }
    }
}
