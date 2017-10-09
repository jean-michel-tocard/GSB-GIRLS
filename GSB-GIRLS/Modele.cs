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

            static public void Initialise()
            {

                maConnexion = new GSBgirls();
            }

        }
    }

