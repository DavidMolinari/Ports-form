using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Gestion_Navire
{
    /// <summary>
    /// Class NavirePassager qui hérite de ToutNavire
    /// </summary>
    public class NavirePassager : ToutNavire
    {
        private int _NbMaxiPassager;
        private int _NbMaxiChambres;
        private int _NbCouchettes;
        private static int _NbNavirePassager;
        /// <summary>
        /// Constructeur de la classe NavirePassager qui fait appel au constructeur de la classe mère, ToutNavire
        /// </summary>
        /// <param name="noLloyds"></param>
        /// <param name="nomNavire"></param>
        /// <param name="pavillon"></param>
        /// <param name="longueur"></param>
        /// <param name="largeur"></param>
        /// <param name="tirantEau"></param>
        /// <param name="nbMaxiPAssager"></param>
        /// <param name="nbMaxiChambres"></param>
        /// <param name="nbCouchettes"></param>
        public NavirePassager(int noLloyds, string nomNavire,
            string pavillon, int longueur, int largeur,
            int tirantEau, int nbMaxiPAssager, int nbMaxiChambres, int nbCouchettes) :base(noLloyds, nomNavire, pavillon, longueur, largeur, tirantEau)
        {
            this.NbCouchettes = _NbCouchettes;
            this.NbMaxiPassager = NbMaxiPassager;
            this.NbMaxiChambres = nbMaxiChambres;
        }
       

        public int NbMaxiPassager
        {
            get
            {
                return _NbMaxiPassager;
            }

            set
            {
                _NbMaxiPassager = value;
            }
        }
        public int NbMaxiChambres
        {
            get
            {
                return _NbMaxiChambres;
            }

            set
            {
                _NbMaxiChambres = value;
            }
        }
        public int NbCouchettes
        {
            get
            {
                return _NbCouchettes;
            }

            set
            {
                _NbCouchettes = value;
            }
        }
        public static int NbNavirePassager
        {
            get
            {
                return _NbNavirePassager;
            }

            set
            {
                _NbNavirePassager = value;
            }
        }


    }
}
