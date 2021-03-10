using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MyFoodSupply
{
    [TestFixture]
    class FoodItemDetailTest
    {
        [Test]
        [TestCase("Pizza", 1, "2025/07/09", 200.98)]
        [TestCase("Burger", 1, "2029/01/13", 90.00)]
        public void CreateFoodDetail_Called_CreateAndReturnMedicineObject(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            FoodDetail result = p.CreateFoodDetail(name,dishType,expiryDate,price);
            Assert.That(result.Name, Is.EqualTo(name));
            Assert.That(result.DishType, Is.EqualTo((FoodDetail.Category)dishType));
            Assert.That(result.Price, Is.EqualTo(price));
            Assert.That(result.ExpiryDate, Is.EqualTo(expiryDate));
        }

        [Test]
        [TestCase("", 1, "2025/07/09", 200.98)]
        [TestCase(null, 1, "2029/01/13", 90.00)]
        public void FoodItem_CheckNameEqualto_NullOrNotNull(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase("Pizza", 1, "2025/07/09", -7)]
        [TestCase("Dosa", 1, "2029/01/13", -4)]
        public void FoodItem_CheckPrice_LessThanZero(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exception.Message);
        }
        
        [Test]
        [TestCase("Pizza", 1, "2020/07/09", 70.00)]
        [TestCase("Dosa", 1, "2020/01/13", 50.00)]
        public void FoodItem_Check_ExipryDate(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }

    }
}
