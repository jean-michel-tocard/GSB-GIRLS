using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_GIRLS
{
    partial class Visiteur
    {
        public string nomPrenom
        {
            get
            {
                return nom.Trim() + prenom.Trim();
            }
        }

        public string np
        {
            get
            {
                return this.nom + this.prenom;
            }
        }
    }
}
