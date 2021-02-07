using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenClosePrincipal;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class OpenClosed_Tests
    {
        [TestMethod]
        public void Customer_NotClosed()
        {
            //customer before / after are not the same
            var before = new Customer_NotClosed_Before().GetType().GetProperties();
            var after = new Customer_NotClosed_After().GetType().GetProperties();

            Assert.AreNotEqual(before.Count(), after.Count());
        }

        [TestMethod]
        public void Customer_Closed()
        {
            //customer before / after are not the same
            var before = new Customer_Closed_Before().GetType().GetProperties();
            var after = new Customer_Closed_After().GetType().GetProperties();
            var before_address = new Customer_Closed_Before().CustomerAddress;
            var after_address = new Customer_Closed_After().CustomerAddress;

            Assert.AreEqual(before.Count(), after.Count());
            Assert.IsNull(before_address.GetType().GetProperty("Country"));
            Assert.IsNotNull(after_address.GetType().GetProperty("Country"));
        }
    }
}