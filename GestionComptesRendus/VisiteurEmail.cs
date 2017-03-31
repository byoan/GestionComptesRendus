using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionComptesRendus
{
    public partial class VISITEUR
    {
        public String VIS_EMAIL;

        public String getVisEmail()
        {
            return this.VIS_EMAIL;
        }
        public void setVisEmail(String email)
        {
            if (Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                this.VIS_EMAIL = email;
            }
            else
            {
                this.VIS_EMAIL = null;
            }
        }
    }
}
