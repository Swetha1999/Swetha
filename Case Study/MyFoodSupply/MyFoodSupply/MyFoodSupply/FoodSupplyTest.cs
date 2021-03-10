using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply
{
    [TestFixture]
    class FoodSupplyTest
    {
        [Test]
        [TestCase("",2, "2021/09/07", 70.00)]
        public void FoodItemName_IsNullOrEmpty(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Dish name cannot be empty. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("abc", 2, "2021/09/07", -1)]
        public void FoodItemPrice_IsNullOrEmpty(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect value for dish price. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("abc",2 , "2020/09/07", 70.00)]
        public void FoodItemDate_LessThan_PresentDate(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateFoodDetail(name, dishType, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("Sdf", 2, "2021/09/07", 80.00)]
        public void CreateFoodItemDetail_WhenCalled_CreateAndReturnFoodItem(string name, int dishType, DateTime expiryDate, double price)
        {
            Program p = new Program();
            FoodDetail m = p.CreateFoodDetail(name, dishType, expiryDate, price);
            Assert.That(m.Price, Is.EqualTo(price));
        }
        public FoodDetail get(int n)
        {
            if (n == 1)
            {
                return new FoodDetail()
                {

                    Name = "medicine",
                    DishType = FoodDetail.Category.MainDish,
                    ExpiryDate = new DateTime(2021, 09, 08),
                    Price = 90.00
                };
            }
            else
            {
                return null;
            }

        }
        [Test]
        [TestCase(1, "2021/08/07", "abv",20.00, 1)]
        public void CreateSupllyDetail_ObjectNotNull(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);
            SupplyDetail res = p.CreateSupplyDetail(foodItemCount, requestDate,sellerName,packingCharge, m);
            Assert.That(res.Count, Is.EqualTo(foodItemCount));
            Assert.That(res.RequestDate, Is.EqualTo(requestDate));
            Assert.That(res.SellerName, Is.EqualTo(sellerName));
            Assert.That(res.FoodItem, Is.EqualTo(m));
        }
        [Test]
        [TestCase(-1, "2021/08/07", "bvc", 20.00, 1)]
        public void CreateSupllyDetail_FoodItemCountLessThanZero(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m));
            Assert.AreEqual("Incorrect food item count. Please check", exception.Message);
        }
        [Test]
        [TestCase(1, "2020/08/07", "bvc", 20.00, 1)]
        public void CreateSupplyDetail_LauchDateLessThan_CurrentDate(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m));
            Assert.AreEqual("Incorrect food request date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase(1, "2021/08/07", "abh", 20.00, 0)]
        public void CreateSupplyDetail_ObjectNull(int foodItemCount, DateTime requestDate, string sellerName, double packingCharge, int n)
        {
            Program p = new Program();
            FoodDetail m;
            m = get(n);
            SupplyDetail res = p.CreateSupplyDetail(foodItemCount, requestDate, sellerName, packingCharge, m);
            Assert.That(res, Is.EqualTo(null));
        }

    }
}
