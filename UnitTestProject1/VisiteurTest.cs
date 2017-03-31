using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionComptesRendus;
using System.Text.RegularExpressions;

namespace GestionComptesRendus
{
    [TestClass]
    public class VisiteurTest
    {
        public String wrongEmail = "testàtest.com";
        public String rightEmail = "visiteur@gmail.com";

        [TestMethod]
        public void TestWrongEmail()
        {
            var visiteur = new VISITEUR();
            visiteur.setVisEmail(this.wrongEmail);
            //Shouldn't be accepted
            Assert.AreNotEqual(this.wrongEmail, visiteur.VIS_EMAIL);
        }

        [TestMethod]
        public void TestRightEmail()
        {
            var visiteur = new VISITEUR();
            visiteur.setVisEmail(this.rightEmail);
            //Should be accepted
            Assert.AreEqual(this.rightEmail, visiteur.getVisEmail());
        }
    }
}
