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
    public partial class CompteRenduDeVisite : Form
    {
        public CompteRenduDeVisite()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var rapportListe = context.RAPPORT_VISITE.ToList();
                List<string> result = new List<string>();
                
                for (var i = 0; i < rapportListe.Count; i++)
                {
                    result.Add(context.PRATICIEN.Find(short.Parse(rapportListe[i].PRA_NUM.ToString())).PRA_NOM);
                }
                comboBox1.DataSource = result.ToList(); 
            }
        }

        private void CompteRenduDeVisite_Load(object sender, EventArgs e)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                int idCurrentRapport = int.Parse(textBox1.Text);
                string idCurrentVisMed = label4.Text;
                var currentPraticienNum = context.RAPPORT_VISITE.Find(idCurrentVisMed, idCurrentRapport).PRA_NUM;
                var praticienName = context.PRATICIEN.Find(currentPraticienNum);
                comboBox1.Text = praticienName.PRA_NOM;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void entityBindingNavigator1_PositionChanged(object sender, EventArgs e)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                int idCurrentRapport = int.Parse(textBox1.Text);
                string idCurrentVisMed = label4.Text;
                var currentPraticienNum = context.RAPPORT_VISITE.Find(idCurrentVisMed, idCurrentRapport).PRA_NUM;
                var praticienName = context.PRATICIEN.Find(currentPraticienNum);
                comboBox1.Text = praticienName.PRA_NOM;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PraticienDetails window = new PraticienDetails(int.Parse(label8.Text));
            window.Show();
        }

        private void entityBindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                int currentIdRapport = int.Parse(textBox1.Text);
                string idCurrentVisMed = label4.Text;
                var currentRapport = context.RAPPORT_VISITE.Find(idCurrentVisMed, currentIdRapport);
                String motifVisite = textBox2.Text;
                String bilan = textBox3.Text;

                currentRapport.RAP_BILAN = bilan;
                currentRapport.RAP_MOTIF = motifVisite;

                var rowsList = dataGridView1.Rows;
                if (rowsList != null)
                {
                    for (var i = 0; i < rowsList.Count; i++)
                    {
                        var ligneMedicamentOffert = context.OFFRIR.Find(idCurrentVisMed, currentIdRapport, dataGridView1.Rows[i].Cells[0].Value.ToString());
                        if (ligneMedicamentOffert == null)
                        {
                            MessageBox.Show("Impossible de trouver le médicament à mettre à jour (ligne " + dataGridView1.Rows[i] + ")");
                        }
                        /*if (dataGridView1.Rows[i].Cells[1].Value == null)
                        {
                            dataGridView1.Rows[i].Cells[1].Value = 0;
                            MessageBox.Show(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        }*/

                        ligneMedicamentOffert.OFF_QTE = short.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());

                        //ligneMedicamentOffert.OFF_QTE = Math.Max((short)0, short.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                    }
                }

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Enregistrement effectué");
                } else
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'enregistrement");
                }
            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value == null)
            {
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = "0";
            }
        }
    }
}
