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
        NavireFret unNavireFret;
        NavirePassager unNavirePassager;

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
                unNavireFret = new NavireFret(
                    Convert.ToInt32(this.TxNumLLOYD.Text), this.TxNomNavire.Text, this.TxPavillon.Text, Convert.ToInt16(this.TxLongueur.Text),
                    Convert.ToInt32(this.TxLargeur.Text), Convert.ToInt32(this.TxTirant.Text), this.TxLibelleFret.Text, Convert.ToInt32(this.TxQuantiteFret.Text), Convert.ToInt32(this.TxNumFret.Text));
                MessageBox.Show("Navire Fret créé");
            }
            else MessageBox.Show("Veuillez remplir tous les champs !");

            
           
            
        }

        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
            unPort = new Port(this.TxNomPort.Text);
            MessageBox.Show ("Le port : " + this.TxNomPort.Text + " a été créé !");
        }

        private void BtnCreerNavirePassager_Click(object sender, EventArgs e)
        {
            var myStrings = new List<string> {
                Convert.ToString(this.TxTirant.Text), this.TxNomNavire.Text, this.TxPavillon.Text,
                Convert.ToString(this.TxLongueur.Text), Convert.ToString(this.TxLargeur.Text),
                Convert.ToString(this.TxTirant.Text), Convert.ToString(this.TxNbMaxiPassager.Text), Convert.ToString(this.TxNbChambre.Text), Convert.ToString(this.TxNbCabine.Text)};
            if (!(myStrings.All(s => s == null)))
            {
                unNavirePassager = new NavirePassager(
                    Convert.ToInt32(this.TxNumLLOYD.Text), this.TxNomNavire.Text, this.TxPavillon.Text, Convert.ToInt16(this.TxLongueur.Text),
                    Convert.ToInt32(this.TxLargeur.Text), Convert.ToInt32(this.TxTirant.Text), Convert.ToInt32(this.TxNbMaxiPassager.Text), Convert.ToInt32(this.TxNbChambre.Text), Convert.ToInt32(this.TxNbCabine.Text));
                MessageBox.Show("Navire Passager créé");
            }
            else MessageBox.Show("Veuillez remplir tous les champs !");

        }

        private void BtnAffecterPort_Click(object sender, EventArgs e)
        {
            unPort.AjouterNavire(unNavireFret);
            MessageBox.Show("Le navireFret : " + this.unNavireFret.NomNavire + " a été affecté  !");        
        }

        private void BtnAffecterAuPort2_Click(object sender, EventArgs e)
        {
            unPort.AjouterNavire(unNavirePassager);
            MessageBox.Show("Le NavirePassager : " + this.unNavirePassager.NomNavire + " a été affecté !");
        }
    }
}
