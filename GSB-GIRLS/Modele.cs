using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_GIRLS
{
    static class Modele
    {
        static GSBgirls maConnexion;
        static Visiteur unVisiteur;
        static Secteur unSecteur;


        public static GSBgirls MaConnexion
        {
            get
            {
                return maConnexion;
            }

            set
            {
                maConnexion = value;
            }
        }

        public static Visiteur UnVisiteur
        {
            get
            {
                return unVisiteur;
            }

            set
            {
                unVisiteur = value;
            }
        }
        public static Secteur UnSecteur
        {
            get
            {
                return unSecteur;
            }

            set
            {
                unSecteur = value;
            }
        }
        static public void Initialise()
        {
            maConnexion = new GSBgirls();
            unVisiteur = new Visiteur();
            unSecteur = new Secteur();
        }
    }
}

