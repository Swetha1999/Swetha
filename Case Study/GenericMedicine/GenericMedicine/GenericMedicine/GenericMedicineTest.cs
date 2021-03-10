using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicine
{
    [TestFixture]
    class GenericMedicineTest
    {
        //public static Medicine m;
        [Test]
        [TestCase("","name","medicine","2021/09/07",70.00)]
        public void GenericNameIsNullOrEmpty(string name,string genericMedicineName,string composition,DateTime expiryDate,double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price));
            Assert.AreEqual("Medicine name cannot be empty. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("abc", "name", "medicine", "2021/09/07",-1)]
        public void GenericPriceIsNullOrEmpty(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price));
            Assert.AreEqual("Incorrect value for Medicine price per strip. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("abc", "name", "medicine", "2020/09/07", 70.00)]
        public void GenericDateIsNullOrEmpty(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            Program p = new Program();
            var exception = Assert.Throws<Exception>(() => p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price));
            Assert.AreEqual("Incorrect expiry date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase("Sdf","name","medicine","2021/09/07",80.00)]
        public void CreateMedicineDetail_WhenCalled_CreateAndReturnMedicine(string name, string genericMedicineName, string composition, DateTime expiryDate, double price)
        {
            Program p = new Program();
            Medicine m = p.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, price);
            Assert.That(m.PricePerStrip,Is.EqualTo(price));
        }
        public Medicine get(int n)
        {
            if (n == 1)
            {
                return new Medicine()
                {

                    Name = "medicine",
                    GenericMedicineName = "abv",
                    Composition = "mkl",
                    ExpiryDate = new DateTime(2021, 09, 08),
                    PricePerStrip = 90.00
                };
            }
            else{
                return null;
            }

        }
        [Test]
        [TestCase(1,"2021/08/07","Chennai",1)]
        public void  CreateCartonDetail_ObjectNullOrNot(int medicineStripCount, DateTime launchDate, string retailerAddress,int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);
            CartonDetail res = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            Assert.That(res.MedicineStripCount, Is.EqualTo(medicineStripCount));
            Assert.That(res.LaunchDate ,Is.EqualTo(launchDate));
            Assert.That(res.RetailerAddress, Is.EqualTo(retailerAddress));
        }
        [Test]
        [TestCase(-1, "2021/08/07", "Chennai", 1)]
        public void CreateCartonDetail_medicineStripCountLessThanZero(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);
             
            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect strip count. Please check", exception.Message);
        }
        [Test]
        [TestCase(1, "2020/08/07", "Chennai", 1)]
        public void CreateCartonDetail_LauchDateLessThanZero(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);

            var exception = Assert.Throws<Exception>(() => p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m));
            Assert.AreEqual("Incorrect launch date. Please provide valid value", exception.Message);
        }
        [Test]
        [TestCase(1, "2021/08/07", "Chennai", 0)]
        public void CreateCartonDetail_ObjectNull(int medicineStripCount, DateTime launchDate, string retailerAddress, int n)
        {
            Program p = new Program();
            Medicine m;
            m = get(n);
            CartonDetail res = p.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, m);
            
            Assert.That(res, Is.EqualTo(null));
        }
    }
}
