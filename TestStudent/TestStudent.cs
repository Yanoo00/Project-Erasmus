using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projet_Erasmus
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Student_Create_Success()
        {
            //Given
            //je déclare un objet de type "student"
            Student testStudentActual;
            string testNameExpected = "Roberto";

            Boolean testIsCaptExpected = true;

            List<int> testListOfChoices = new List<int> { 1, 2, 3, 4 };


            //then
            //je récupère mon objet (instancier)
            testStudentActual = new Student(testNameExpected, testIsCaptExpected, testListOfChoices);

            //when


            //Je compare les valeurs de mon objet avec les
            //paramètres que j'ai passés dans le constructeur
            //Normalement on ne fait qu'un test par méthode de test (sinon ce n'est pas un test unitaire)
            Assert.AreEqual(testNameExpected, testStudentActual.Name);
            Assert.AreEqual(testIsCaptExpected, testStudentActual.IsCapt);
            Assert.AreEqual(testListOfChoices.Count, testStudentActual.ListOfChoices.Count);         }
    }
}
