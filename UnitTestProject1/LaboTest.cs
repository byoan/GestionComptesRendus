using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionComptesRendus
{
    [TestClass]
    public class LaboTest
    {
        private const String wrongLabCode = "ABC";
        private const String wrongLabNom = "123";
        private const String wrongChefLabo = "456";

        private const String correctLabCode = "GB";
        private const String correctLabNom = "Laboratoire Cyka";
        private const String correctChefLabo = "Mr Blyat";
        [TestMethod]
        public void TestWrongLabo()
        {
            var labo = new LABO();
            labo.LAB_CODE = wrongLabCode;
            labo.LAB_NOM = wrongLabNom;
            labo.LAB_CHEFVENTE = wrongChefLabo;

            Assert.IsFalse(labo.LAB_CODE.Length > 0 && labo.LAB_CODE.Length <= 2);
            Assert.IsTrue(Regex.IsMatch(labo.LAB_NOM, @"\d"));
            Assert.IsTrue(Regex.IsMatch(labo.LAB_CHEFVENTE, @"\d"));
            
        }

        [TestMethod]
        public void TestCorrectLabo()
        {
            var labo = new LABO();
            labo.LAB_CODE = correctLabCode;
            labo.LAB_NOM = correctLabNom;
            labo.LAB_CHEFVENTE = correctChefLabo;

            Assert.IsTrue(labo.LAB_CODE.Length > 0 && labo.LAB_CODE.Length <= 2);
            Assert.IsFalse(Regex.IsMatch(labo.LAB_NOM, @"\d"));
            Assert.IsFalse(Regex.IsMatch(labo.LAB_CHEFVENTE, @"\d"));
        }
    }
}
