using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using CustomerCommLib;
namespace CustomerCommLib
{
    [TestFixture]
    class CustomerComm_Test
    {
        Mock<IMailSender> mock;
        CustomerComm obj;

        [Test]
        [TestCase("ramya98@gmail.com", "hai", true)]
        public void OneTimeSetUp(string toaddress, string msg, bool expected)
        {
            mock = new Mock<IMailSender>();

            mock.Setup(p => p.SendMail(toaddress, msg)).Returns(expected);
            obj = new CustomerComm(mock.Object);

            bool actual = obj.SendMailToCustomer();
            Assert.AreEqual(expected, actual);
        }


    }
}
