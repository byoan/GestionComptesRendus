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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            checkCredentials(login, password);

        }

        
        private bool checkCredentials(string login, string password)
        {
            using (GestionComptesRendusEntities context = new GestionComptesRendusEntities())
            {
                var visiteur = context.VISITEUR.SqlQuery("SELECT * FROM VISITEUR WHERE VIS_NOM like '" + login + "';").ToList();               
                
                if (visiteur != null)
                {
                    for (var i = 0; i<visiteur.Count();i++)
                    {
                        if (visiteur[i].VIS_NOM == login && DateTime.Parse("" + visiteur[i].VIS_DATEEMBAUCHE).ToString() == (DateTime.Parse(password).ToString()))
                        {
                            this.Hide();
                            Menu mainMenu = new Menu();
                            mainMenu.Show();
                            return true;
                        }
                    }
                }
                MessageBox.Show("Les accès fournis sont incorrects. Veuillez réessayer.");
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
