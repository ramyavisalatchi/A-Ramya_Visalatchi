using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GenericMedicine
{
    [TestFixture]
    class GenericMedicineTest
    {
        [Test]
        [TestCase("ABC", "ABC", "ABC", "2022/07/09", 200.98)]
        [TestCase("DEF", "DEF", "DEF", "2029/01/13", 90.00)]
        public void CreateMedicineDetail_Called_CreateObject(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            Medicine result = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.GenericMedicineName, Is.EqualTo(genericMedicineName));
            Assert.That(result.Composition, Is.EqualTo(composition));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
            Assert.That(result.PricePerStrip, Is.EqualTo(pricePerStrip));
        }

        [Test]
        [TestCase("","SaliAc","sacilic acid","2022/08/08",780.00)]
        [TestCase(null, "SaliAc", "sacilic acid", "2022/08/08", 780.00)]
        public void GenericMedicineCheckNameEqualtoNullOrNotNull(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Medicine name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("sac", "SaliAc", "sacilic acid", "2022/08/08", -2)]
        public void GenericMedicinePriceLessThanZero(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("sac", "SaliAc", "sacilic acid", "2020/08/08", 200.9)]
        public void GenericMedicineCheckExpiryDate(string name, string genericMedicineName, string composition, DateTime expiryDate, double pricePerStrip)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
    }
}
