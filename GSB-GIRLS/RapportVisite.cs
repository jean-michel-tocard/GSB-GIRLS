using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_GIRLS
{
    public partial class RapportVisite : Form
    {
        private GSBgirls maConnexion;
        private Visiteur levisiteur;
        int ceIdRapport;
        public RapportVisite(GSBgirls MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteur = Levisiteur;
        }
    }
}
