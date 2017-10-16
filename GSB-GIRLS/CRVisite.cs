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
    public partial class CRVisite : Accueil
    {
        private bool fermeture = false;
        public CRVisite()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (fermeture) return;
           // var LQuery = Modele.MaConnexion.MEDECIN.ToList()
                          // .Where(x => x.idStyle == int.Parse(cboPracticien.SelectedValue.ToString()));

        }

        private void CRVisite_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID,Nom,Prenom,IDspec,adresse");
        }
    }
}
