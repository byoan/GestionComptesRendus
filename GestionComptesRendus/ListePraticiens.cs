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
    public partial class ListePraticiens : Form
    {
        public ListePraticiens()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var listePraticiens = context.PRATICIEN.ToList();

                List<string> result = new List<string>();
                result.Add("Choissisez un praticien ..."); // Valeur 0 pour la combo box

                for (var i = 0; i < listePraticiens.Count; i++)
                {
                    result.Add(listePraticiens[i].PRA_NOM + " " + listePraticiens[i].PRA_PRENOM);
                }
                
                comboBox1.DataSource = result;
            }
        }

        private void ListePraticiens_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
                {
                    var praticien = context.PRATICIEN.Find(comboBox1.SelectedIndex);
                    textBox1.Text = praticien.PRA_NOM.ToString();
                    textBox2.Text = praticien.PRA_PRENOM.ToString();
                    textBox3.Text = praticien.PRA_ADRESSE.ToString();
                    textBox4.Text = praticien.PRA_CP.ToString();
                    textBox5.Text = praticien.PRA_VILLE.ToString();
                    textBox6.Text = praticien.PRA_COEFNOTORIETE.ToString();
                    textBox7.Text = praticien.TYP_CODE.ToString();
                    textBox8.Text = praticien.PRA_NUM.ToString();
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
                textBox7.Text = "";
                textBox8.Text = "";
            }
        }
    }
}
