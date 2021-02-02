using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance;
using FluentAssertions;
using System;

namespace Tests
{
    [TestClass]
    public class Inheritance_Tests
    {
        [TestMethod]
        public void PersonObjects_Instantiate_ReturnsNameAsEntered()
        {

            Assert.AreEqual(_person.Name, _customer.Name);
            Assert.AreEqual(_person.Name, _employee.Name);
            Assert.AreEqual("doug", _person.Name);
        }

        [TestMethod]
        public void Person_SendEmail_ReturnsStringStartingWithSendingMessage()
        {
            var result = _person.SendEmail("");
            result.Should().StartWith("sending message");
        }

        [TestMethod]
        public void Person_SendEmail_NoEmailPresent_ReturnsStringStartingWithNoEmail()
        {
            var personNoEmail = new Person("Rita");
            var result = personNoEmail.SendEmail("");
            result.Should().StartWith("no email on file");
        }

        [TestMethod]
        public void Person_PrintProperCaseName_ReturnsNameInTitleCase()
        {
            var result = _person.PrintProperCaseName();
            result.Should().Be("Doug");
        }

        [TestMethod]
        public void Customer_PrintPurchaseReceipt_ReturnsReceiptString()
        {
            var result = _customer.PrintPurchaseReceipt();
            result.Should().StartWith("Printing receipt");
        }

        [TestMethod]
        public void Customer_SendEmail_UsesBaseClassAndOverrides()
        {
            var result = _customer.SendEmail("");
            result.Should().StartWith("sending message to");
            result.Should().Contain("sending customer email");
        }

        [TestMethod]
        public void Customer_GetBaseType_ReturnsPerson()
        {
            Assert.AreEqual(_customer.GetType().BaseType, _person.GetType());
        }

        [TestMethod]
        public void Customer_ExecuteBaseClassMethod_ReturnsProperCase()
        {
            var result = _customer.PrintProperCaseName();
            Assert.AreEqual("Doug", result);
        }

        [TestMethod]
        public void Customer_CheckFirstPurchaseDate_Returns15DaysAgo()
        {
            var now = DateTime.Now.AddDays(-15);
            var result = _customer.FirstPurchaseDate;
            result.Year.Should().Be(now.Year);
            result.Month.Should().Be(now.Month);
            result.Day.Should().Be(now.Day);

        }

        [TestMethod]
        public void Employee_GivePayCheck_ReturnsStringStartingWithPrintingPaycheck()
        {
            var result = _employee.GivePayCheck();
            result.Should().StartWith("Printing paycheck");
        }

        [TestMethod]
        public void Employee_PayCheckAmount_Returns100()
        {
            _employee.PayCheckAmount.Should().Be(100);
        }

        [TestMethod]
        public void Employee_SendEmail_ReturnsSameValueAsPerson()
        {
            var result = _employee.SendEmail("");
            result.Should().NotContain("sending customer email");
            result.Should().StartWith("sending internal");
        }

        [TestInitialize]
        public void Init()
        {
            _person = new Person("doug");
            _person.Email = "doug@person.net";
            _customer = new Customer("doug");
            _customer.Email = "doug@customer.net";
            _employee = new Employee("doug");
            _employee.Email = "doug@work.net";
        }

        private Person _person;
        private Customer _customer;
        private Employee _employee;
    }
}