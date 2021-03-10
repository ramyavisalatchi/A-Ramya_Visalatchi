using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MyFoodSupply
{
    [TestFixture]
    class SupplyDetailTest
    {
        private FoodDetail GetFoodDetailObject(int n)
        {
            if (n == 1)
            {
                return new FoodDetail()
                {
                    Name = "IceCream",
                    DishType = FoodDetail.Category.Dessert,
                    Price = 67.90,
                    ExpiryDate = new DateTime(2022, 11, 10),

                };
            }
            else
            {
                return null;
            }
        }
        [Test]
        [TestCase(12, "2021/07/09", "John", 100.98, 1)]
        [TestCase(23, "2021/08/13", "Bobby", 50.50, 1)]
        public void SupplyDetail_Called_CreateAndReturnObject(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail f;
            f = GetFoodDetailObject(n);

            SupplyDetail result = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f);
            Assert.That(result.Count, Is.EqualTo(foodItemCount));
            Assert.That(result.RequestDate, Is.EqualTo(requestDate));
            Assert.That(result.SellerName, Is.EqualTo(sellerName));
            //Assert.That(result.PackingCharge, Is.EqualTo(packingCharge));
            Assert.That(result.FoodItem, Is.EqualTo(f));
        }

        [Test]
        [TestCase(-12, "2022/07/09", "John", 100, 1)]
        [TestCase(-3, "2022/08/13", "Bobby", 50, 1)]
        public void CreateFoodDetail_IfFoodItemCountIsLessThanZero_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail f;
            f = GetFoodDetailObject(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f));
            Assert.AreEqual("Incorrect food item count. Please check", exception.Message);
        }

        [Test]
        [TestCase(12, "2020/07/09", "John", 100, 1)]
        [TestCase(23, "2020/08/13", "Bobby", 50, 1)]
        public void CreateFoodDetail_IfLaunchDateIsLessThanCurrentDate_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail f;
            f = GetFoodDetailObject(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", exception.Message);
        }

        [Test]
        [TestCase(-12, "2022/07/09", "John", 100, 0)]
        [TestCase(-3, "2022/08/13", "Bobby", 50, null)]
        public void CreateSupplyDetail_IfNullFoodDetaiObjectISPassed_Exception(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail f;
            f = GetFoodDetailObject(n);

            SupplyDetail res = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, f);
            Assert.That(res, Is.EqualTo(null));
        }
    }
}

