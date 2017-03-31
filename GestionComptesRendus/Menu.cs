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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompteRenduDeVisite compteRendu = new CompteRenduDeVisite();
            compteRendu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeVisiteursMedicaux window = new ListeVisiteursMedicaux();
            window.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListePraticiens window = new ListePraticiens();
            window.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListeMedicaments window = new ListeMedicaments();
            window.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm window = new LoginForm();
            window.Show();
        }
    }
}
