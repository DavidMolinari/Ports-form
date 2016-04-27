using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Gestion_Navire
{

    /// <summary>
    /// Class Port qui va contenir une collection d'objets de type ToutNavire
    /// </summary>
    public class Port
    {
        private List<ToutNavire> TousLesNavirePort;
        private string _NomPort;
        private int _NbNavireFret;
        private int _NbNaviresPassagers;


        public Port(string nomPort)
        {
            this.NomPort = nomPort;
            this.TousLesNavirePort = new List<ToutNavire>();
        }


        /// <summary>
        /// Méthode qui permet d'ajouter un objet de type NavireFret à la collection TouslesNavirePort
        /// </summary>
        /// <param name="navireFret"></param>
        public void AjouterNavire(NavireFret navireFret)
        {
            this.TousLesNavirePort.Add(navireFret);
            NavireFret.NbNavireFret++;
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un objet de type NavirePassager à la collection TouslesNavirePort
        /// Méthode surchargée.
        /// </summary>
        /// <param name="navirePassager"></param>
        public void AjouterNavire(NavirePassager navirePassager)
        {
            this.TousLesNavirePort.Add(navirePassager);
            NavirePassager.NbNavirePassager++;
        }

        /// <summary>
        /// Méthode pour supprimer unNavire de la collection TousLesNaviresPort à l'indice i
        /// </summary>
        /// <param name="i"></param>
        public void SupprimerNavire(int i)
        {

            if(this.TousLesNavirePort[i] is NavirePassager)
            {
                this.TousLesNavirePort.RemoveAt(i);
                NavirePassager.NbNavirePassager--;

            } else if (this.TousLesNavirePort[i] is NavireFret)
            {
                this.TousLesNavirePort.RemoveAt(i);
                NavireFret.NbNavireFret--;
            }
        }

             	

	
        /// <summary>
        /// Méthode pour extraite un Navire
        /// </summary>
        /// <param name="i"></param>
        /// <return> Retourne un Objet de type toutNavire</returns>
        public ToutNavire ExtraiteNavire(int i)
        {
            return this.TousLesNavirePort[i];
           
        }
        // Getters & Setters
        public string NomPort
        {
            get
            {
                return _NomPort;
            }

            set
            {
                _NomPort = value;
            }
        }

        public int NbNavireFret
        {
            get
            {
                return _NbNavireFret;
            }

            set
            {
                _NbNavireFret = value;
            }
        }

        public int NbNaviresPassagers
        {
            get
            {
                return _NbNaviresPassagers;
            }

            set
            {
                _NbNaviresPassagers = value;
            }
        }
    }
}
