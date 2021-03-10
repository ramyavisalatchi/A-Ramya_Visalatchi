using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace GenericMedicine
{
    class CartonDetailTest
    {
        private Medicine GetMedicineObject(int n)
        {
            if (n==1)
            {
                return new Medicine()
                {
                    Name = "ABC",
                    GenericMedicineName = "ABC",
                    Composition = "ABC",
                    ExpiryDate = new DateTime(2032, 11, 10),
                    PricePerStrip = 30
                };
            }
            else 
            {
                return null;
            }
        }



        [Test]
        [TestCase(12,"2022/07/09", "ABC",1)]
        [TestCase(23,"2029/01/13", "DEF",1)]
        public void CartonDetail_Called_ObjectCreated(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(n);

            CartonDetail result = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(result.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(result.RetailerAddress, Is.EqualTo(retailerAddress));
            Assert.That(result.LaunchDate, Is.EqualTo(launchDate));
            Assert.That(result.Medicine, Is.EqualTo(m));
        }

        [Test]
        [TestCase(-5, "2022/11/6", "ABC", 1)]
        [TestCase(-6, "2022/6/7", "DEF", 1)]
        public void CreateCartonDetail_IfNegativeStripCount_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(n);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);
        }

        [Test]
        [TestCase(5, "2020/11/6", "ABC", 1)]
        [TestCase(6, "2020/6/7", "DEF", 1)]
        public void CreateCartonDetail_IfLaunchDateIsLessThanCurrentDate_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(n);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase(4,"2022/09/08","ABC",1)]
        [TestCase(2,"2021/08/08","ABC",null)]
        public void CreateCartonDetail_IfNullMedicineObjectISPassed_Exception(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = GetMedicineObject(n);

            CartonDetail res = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(res, Is.EqualTo(null));
        }
    }
}
