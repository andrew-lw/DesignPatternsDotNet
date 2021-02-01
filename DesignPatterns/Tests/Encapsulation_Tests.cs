using Encapsulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Encapsulation_Tests
    {
        [TestMethod]
        public void Person_NoEncapsulation_InstantiateMisCapitalizedName_ReturnsMiscapitalizedName()
        {
            string misCappedName = "aNdReW";
            Person_NoEncapsulation personMisCapped = new Person_NoEncapsulation(misCappedName);
            //this check is case sensitive
            Assert.AreEqual(misCappedName, personMisCapped.FirstName);
        }

        [TestMethod]
        public void Person_NoEncapsulation_InstantiateWithEmptyString_ReturnsMissingString()
        {
            Person_NoEncapsulation personMisCapped = new Person_NoEncapsulation(string.Empty);
            //this check is case sensitive
            Assert.AreEqual(string.Empty, personMisCapped.FirstName);
        }

        [TestMethod]
        public void Person_NoEncapsulation_InstantiateWithNullString_ReturnsMissingString()
        {
            string nullString = null;
            Person_NoEncapsulation personMisCapped = new Person_NoEncapsulation(nullString);
            //this check is case sensitive
            Assert.IsNull(personMisCapped.FirstName);
        }

        [TestMethod]
        public void Person_Encapsulation_InstantiateMisCapitalizedName_ReturnsCapitalizedName()
        {
            string misCappedName = "aNdReW";
            Person_Encapsulation person = new Person_Encapsulation(misCappedName);
            //this check is case sensitive
            Assert.AreNotEqual(misCappedName, person.FirstName);
            Assert.AreEqual("Andrew", person.FirstName);
        }


        [TestMethod]
        public void Person_Encapsulation_InstantiateWithEmptyString_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Person_Encapsulation(string.Empty), "input for FirstName can not be null or empty");
        }

        [TestMethod]
        public void Person_Encapsulation_InstantiateWithNullString_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Person_Encapsulation(null), "input for FirstName can not be null or empty");
        }
    }
}