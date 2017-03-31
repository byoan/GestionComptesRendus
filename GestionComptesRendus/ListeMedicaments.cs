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
    public partial class ListeMedicaments : Form
    {
        public ListeMedicaments()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var listeMedicaments = context.MEDICAMENT.ToList();

                List<string> result = new List<string>();

                for (var i = 0; i < listeMedicaments.Count; i++)
                {
                    result.Add(listeMedicaments[i].MED_NOMCOMMERCIAL);
                }

                comboBox1.DataSource = result;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ListeMedicaments_Load(object sender, EventArgs e)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var medicament = context.MEDICAMENT.First();
                textBox8.Text = medicament.MED_DEPOTLEGAL.ToString();
                textBox1.Text = medicament.MED_NOMCOMMERCIAL.ToString();
                textBox2.Text = medicament.FAM_CODE.ToString();
                textBox3.Text = medicament.MED_COMPOSITION.ToString();
                textBox5.Text = medicament.MED_EFFETS.ToString();
                textBox4.Text = medicament.MED_CONTREINDIC.ToString();
                textBox6.Text = medicament.MED_PRIXECHANTILLON.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
                {
                    var listeMedicaments = context.MEDICAMENT.ToList();

                    List<string> result = new List<string>();

                    for (var i = 0; i < listeMedicaments.Count; i++)
                    {
                        result.Add(listeMedicaments[i].MED_DEPOTLEGAL);
                    }

                    var depotLegalMedicament = result[comboBox1.SelectedIndex];
                    var medicament = context.MEDICAMENT.Find(depotLegalMedicament);
                    textBox8.Text = medicament.MED_DEPOTLEGAL.ToString();
                    textBox1.Text = medicament.MED_NOMCOMMERCIAL.ToString();
                    textBox2.Text = medicament.FAM_CODE.ToString();
                    textBox3.Text = medicament.MED_COMPOSITION.ToString();
                    textBox5.Text = medicament.MED_EFFETS.ToString();
                    textBox4.Text = medicament.MED_CONTREINDIC.ToString();
                    textBox6.Text = medicament.MED_PRIXECHANTILLON.ToString();
                }
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
            }
        }
    }
}
