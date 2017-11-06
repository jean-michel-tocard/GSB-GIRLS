using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GSB_GIRLS
{
    static class Modele
    {
        static GSBgirls maConnexion;
        static Visiteur visiteurConnect;
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

        public static Visiteur VisiteurConnect
        {
            get
            {
                return visiteurConnect;
            }

            set
            {
                visiteurConnect = value;
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
        }
    }
}

