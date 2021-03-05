using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerComm_Tests
{
    [TestFixture]
    public class CustomerTests
    {

        Mock<IMailSender> mock;
        CustomerComm obj;

        [Test]
        [TestCase("cust123@abc.com", "hi", true)]
        public void OneTimeSetUp(string toaddress, string name, bool expected)

        {
            mock = new Mock<IMailSender>();

            mock.Setup(p => p.SendMail(toaddress, name)).Returns(expected);
            obj = new CustomerComm(mock.Object);

            bool actual = obj.SendMailToCustomer();
            Assert.AreEqual(expected, actual);
        }
    }

}
