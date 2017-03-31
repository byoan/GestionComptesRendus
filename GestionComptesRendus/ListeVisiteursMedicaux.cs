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
    public partial class ListeVisiteursMedicaux : Form
    {
        public ListeVisiteursMedicaux()
        {
            InitializeComponent();
            InitComboBox();
        }
        private void InitComboBox()
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var rapportListe = context.VISITEUR.ToList();
                
                List<string> result = new List<string>();

                for (var i = 0; i < rapportListe.Count; i++)
                {
                    result.Add(rapportListe[i].VIS_MATRICULE + " - " + rapportListe[i].VIS_NOM + " " + rapportListe[i].Vis_PRENOM);
                }
                comboBox1.DataSource = result;
            }
        }
        private void entityBindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ListeVisiteursMedicaux_Load(object sender, EventArgs e)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var visiteur = context.VISITEUR.First();
                textBox1.Text = visiteur.VIS_NOM.ToString();
                textBox2.Text = visiteur.Vis_PRENOM.ToString();
                textBox3.Text = visiteur.VIS_ADRESSE.ToString();
                textBox4.Text = visiteur.VIS_CP.ToString();
                textBox5.Text = visiteur.VIS_VILLE.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
                {
                    var rapportListe = context.VISITEUR.ToList();

                    List<string> result = new List<string>();

                    for (var i = 0; i < rapportListe.Count; i++)
                    {
                        result.Add(rapportListe[i].VIS_MATRICULE);
                    }

                    var matriculeVisiteur = result[comboBox1.SelectedIndex];
                    var visiteur = context.VISITEUR.Find(matriculeVisiteur);
                    textBox1.Text = visiteur.VIS_NOM.ToString();
                    textBox2.Text = visiteur.Vis_PRENOM.ToString();
                    textBox3.Text = visiteur.VIS_ADRESSE.ToString();
                    textBox4.Text = visiteur.VIS_CP.ToString();
                    textBox5.Text = visiteur.VIS_VILLE.ToString();
                    textBox6.Text = visiteur.SEC_CODE;
                    textBox7.Text = visiteur.LAB_CODE.ToString();
                }
            }
            else
            {
                using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
                {
                    var visiteur = context.VISITEUR.First();
                    textBox1.Text = visiteur.VIS_NOM.ToString();
                    textBox2.Text = visiteur.Vis_PRENOM.ToString();
                    textBox3.Text = visiteur.VIS_ADRESSE.ToString();
                    textBox4.Text = visiteur.VIS_CP.ToString();
                    textBox5.Text = visiteur.VIS_VILLE.ToString();
                    textBox6.Text = visiteur.SEC_CODE;
                    textBox7.Text = visiteur.LAB_CODE.ToString();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
