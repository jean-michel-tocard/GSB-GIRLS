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
        private static Visiteur monVisiteur;

        private static Visiteur VisiteurConnecte;
        private static string Mois;
        private static int action = 0; //1=Frais Forfait 2=Hors Forfait /!\
        private static string libelle;
        private static int nb;
        private static string lib;

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

        public static Visiteur MonVisiteur
        {
            get
            {
                return monVisiteur;
            }

            set
            {
                monVisiteur = value;
            }
        }

        public static Visiteur VisiteurConnecte1
        {
            get
            {
                return VisiteurConnecte;
            }

            set
            {
                VisiteurConnecte = value;
            }
        }

        public static string Mois1
        {
            get
            {
                return Mois;
            }

            set
            {
                Mois = value;
            }
        }

        public static int Action
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public static string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public static int Nb
        {
            get
            {
                return nb;
            }

            set
            {
                nb = value;
            }
        }

        public static string Lib
        {
            get
            {
                return lib;
            }

            set
            {
                lib = value;
            }
        }

        public static void init()
        {
            MaConnexion = new GSBgirls();
        }
        public static void reinit()
        {
            MaConnexion.Dispose();
            MaConnexion = new GSBgirls();
        }

        static public void Initialise()
        {
            maConnexion = new GSBgirls();
        }
    }
}