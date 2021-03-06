using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq_Handson3;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayerManager.Tests
    {
        [TestFixture]
        public class PlayerManagerTests
        {
            Mock<IPlayerMapper> _mock;

            [OneTimeSetUp]
            public void Init()
            {
                _mock = new Mock<IPlayerMapper>(MockBehavior.Loose);
            }

            [Test]
            [TestCase("John")]

            [TestCase("Bobby")]

            public void RegisterNewPlayer_whencalled_RegisterANewPlayer(string name)
            {
                _mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(false);
                Player result = Player.RegisterNewPlayer(name, _mock.Object);
                NUnit.Framework.Assert.AreEqual(result.Name, name);

            }
            [Test]
            [TestCase(null)]
            [TestCase("")]
            [TestCase("a")]
            [ExpectedException(typeof(ArgumentException))]
            public void RegisterNewPlayer_whencalled_ReturnsArgumentException(string name)
            {
                Player result = Player.RegisterNewPlayer(name, _mock.Object);
            }

        }

    }


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using Moq;
//using Moq_Handson3;
//namespace PlayerManager_Tests
//{
//    [TestFixture]
//    public class PlayerManagerTester
//    {
//        [Test]
//        public void OneTimeSetUp(string name,  bool expected, IPlayerMapper playerMapper = null)
//        {
//            Mock<IPlayerMapper> mock = new Mock<IPlayerMapper>();


//            mock.Setup(p => p.IsPlayerNameExistsInDb(name)).Returns(expected);

//            var obj = new Player();

//            bool actual = obj.RegisterNewPlayer(name, mock.Object);
//            Assert.AreEqual(expected, actual);
//        }
//    }
//}
