using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Gestion_Navire
{
    /// <summary>
    /// Class NavireFret qui hérite de la classe ToutNavire.
    /// </summary>
    public class NavireFret : ToutNavire
    {
        private string _LibelleFret;
        private int _QteFret;
        private static int _NbNavireFret;
        public int nbFret;

        public string LibelleFret
        {
            get
            {
                return _LibelleFret;
            }

            set
            {
                _LibelleFret = value;
            }
        }

        public int QteFret
        {
            get
            {
                return _QteFret;
            }

            set
            {
                _QteFret = value;
            }
        }

        public static int NbNavireFret
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

        /// <summary>
        /// Constructeur de la classe NavireFret qui hérite de ToutNavire
        /// </summary>
        /// <param name="noLLoyds"></param>
        /// <param name="nomNavire"></param>
        /// <param name="pavillon"></param>
        /// <param name="longueur"></param>
        /// <param name="largueur"></param>
        /// <param name="tirantEau"></param>
        /// <param name="libellefret"></param>
        /// <param name="qteFret"></param>
        /// <param name="nbFret"></param>
        public NavireFret(int noLLoyds, string nomNavire, string pavillon,
                          int longueur, int largueur, int tirantEau, string libellefret, int qteFret, int nbFret) :base(noLLoyds,nomNavire, pavillon, longueur, largueur, tirantEau)
        {
            this.LibelleFret = libellefret;
            this.QteFret = qteFret;
            this.nbFret = nbFret;
        }

    }
}
