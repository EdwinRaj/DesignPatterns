using System;
using BuilderPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuilderPatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuilderTest()
        {
            ShopDirector director = new ShopDirector();
            IVehicleBuilder bikeBuilder = new BikeBuilder();
            IVehicleBuilder carBuilder = new CarBuilder();

            VehicleProduct bikeProduct = director.ConstructVehicleProduct(bikeBuilder);
            VehicleProduct carProduct = director.ConstructVehicleProduct(carBuilder);

            bikeProduct.DisplayProduct();
            Console.WriteLine();
            carProduct.DisplayProduct();
        }
    }
}
