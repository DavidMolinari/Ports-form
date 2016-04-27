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
        Port unPort;
        List<ToutNavire> ToutNavires = new List<ToutNavire>();


        public Frm_Gestion_Navire()
        {
            InitializeComponent();
        }

        private void BtnCreerNavireFret_Click(object sender, EventArgs e)
        {
            var myStrings = new List<string> {
                Convert.ToString(this.TxTirant.Text), this.TxNomNavire.Text, this.TxPavillon.Text,
                Convert.ToString(this.TxLongueur.Text), Convert.ToString(this.TxLargeur.Text),
                Convert.ToString(this.TxTirant.Text), this.TxLibelleFret.Text, Convert.ToString(this.TxQuantiteFret.Text), Convert.ToString(this.TxNumFret.Text)};
            if (!(myStrings.All(s => s == null)))
            {
                NavireFret unNavireFret = new NavireFret(
                    Convert.ToInt32(this.TxNumLLOYD.Text), this.TxNomNavire.Text, this.TxPavillon.Text, Convert.ToInt16(this.TxLongueur.Text),
                    Convert.ToInt32(this.TxLargeur.Text), Convert.ToInt32(this.TxTirant.Text), this.TxLibelleFret.Text, Convert.ToInt32(this.TxQuantiteFret.Text), Convert.ToInt32(this.TxNumFret.Text));
                MessageBox.Show("Navire créé");
            }
            else MessageBox.Show("Veuillez remplir tous les champs !");

            
           
            
        }

        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
            unPort = new Port(this.TxNomPort.Text);
        }


        private void BtnCreerNavirePassager_Click(object sender, EventArgs e)
        {
            int numlloyd = Convert.ToInt32(this.TxTirant.Text);
            string nomNavire = this.TxNomNavire.Text;
            string pavillon = this.TxPavillon.Text;
            int longueur = Convert.ToInt32(this.TxLongueur.Text);
            int largueur = Convert.ToInt32(this.TxLargeur.Text);
            int tirantEau = Convert.ToInt32(this.TxTirant.Text);
            int nbMaxPassager = Convert.ToInt32(this.TxNbMaxiPassager.Text);
            int nbChambres = Convert.ToInt32(this.TxNbChambre.Text);
            int nbCabines = Convert.ToInt32(this.TxNbCabine.Text);


            NavirePassager unNavireFret = new NavirePassager(numlloyd, nomNavire, pavillon, longueur, largueur, tirantEau, nbMaxPassager, nbChambres, nbCabines);
        }

        private void BtnAffecterPort_Click(object sender, EventArgs e)
        {
            
        }
    }
}
