using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GSB_GIRLS
{
    public partial class Connexion : Accueil
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connexion = new SqlConnection(@"Data Source =(mdlGSBgirls)");
            SqlDataAdapter sda = new SqlDataAdapter();
            if(SecurityIDType.Rows[0][0].ToString() == '1')
            {
                MessageBox.Show("Connexion établie");
            }
            else
            {
                MessageBox.Show("Connexion refusée");
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
