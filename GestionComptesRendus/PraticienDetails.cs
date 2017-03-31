using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComptesRendus
{
    public partial class PraticienDetails : Form
    {
        bool defaultPraticien = true;
        int visiteurNumberToDisplay = 0;
        public PraticienDetails(int defautVisiteurNumber = 0)
        {
            InitializeComponent();
            if (defautVisiteurNumber != 0)
            {
                this.defaultPraticien = false;
                this.visiteurNumberToDisplay = defautVisiteurNumber;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PraticienDetails_Load(object sender, EventArgs e)
        {
            if (this.defaultPraticien == false)
            {
                using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
                {
                    var praticienName = context.PRATICIEN.Find(this.visiteurNumberToDisplay);
                    textBox1.Text = praticienName.PRA_NUM.ToString();
                    textBox2.Text = praticienName.PRA_NOM.ToString();
                    textBox3.Text = praticienName.PRA_PRENOM.ToString();
                    textBox4.Text = praticienName.PRA_ADRESSE.ToString();
                    textBox5.Text = praticienName.PRA_CP.ToString();
                    textBox6.Text = praticienName.PRA_VILLE.ToString();
                    textBox7.Text = praticienName.PRA_COEFNOTORIETE.ToString();
                    textBox8.Text = praticienName.TYP_CODE.ToString();
                }
            }
        }

        private void entityBindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
