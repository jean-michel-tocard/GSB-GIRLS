using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_GIRLS
{
   public partial class MEDECIN
    {
        public string nomPrenom
        {
            get
            {
                return nom.Trim() +" "+ prenom.Trim();
            }
        }

        public string np
        {
            get
            {
                return this.nom +" "+ this.prenom;
            }
        }
    }
}
