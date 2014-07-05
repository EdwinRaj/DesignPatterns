using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ShopDirector
    {
        public VehicleProduct ConstructVehicleProduct(IVehicleBuilder builder)
        {
            builder.AddEngine();
            builder.AddWheel();
            builder.AddFrame();
            return builder.GetProduct();
        }
    }

    public interface IVehicleBuilder
    {
        void AddWheel();
        void AddEngine();
        void AddFrame();
        VehicleProduct GetProduct();

    }

    public class BikeBuilder : IVehicleBuilder
    {
        private readonly VehicleProduct _bikeProduct = new BikeVehicleProduct();
        public void AddWheel()
        {
            _bikeProduct.AddParts("Two Wheel");
        }

        public void AddEngine()
        {
            _bikeProduct.AddParts("150 cc");
        }

        public void AddFrame()
        {
            _bikeProduct.AddParts("Fiber");
        }

        public VehicleProduct GetProduct()
        {
            return _bikeProduct;
        }
    }

    public class CarBuilder : IVehicleBuilder
    {
        private readonly VehicleProduct _carProduct = new CarVehicleProduct();
        public void AddWheel()
        {
            _carProduct.AddParts("Four Wheel");
        }

        public void AddEngine()
        {
            _carProduct.AddParts("1000 cc");
        }

        public void AddFrame()
        {
            _carProduct.AddParts("Metallic Frame");
        }

        public VehicleProduct GetProduct()
        {
            return _carProduct;
        }
    }

    public abstract class VehicleProduct
    {
        private readonly List<string> _parts = new List<string>(); 
        public void AddParts(string itemName)
        {
            _parts.Add(itemName);
        }

        public void DisplayProduct()
        {
            _parts.ForEach(Console.Write);
        }
    }

    public class CarVehicleProduct : VehicleProduct
    {
       
    }

    public class BikeVehicleProduct : VehicleProduct
    {
       
    }


}
