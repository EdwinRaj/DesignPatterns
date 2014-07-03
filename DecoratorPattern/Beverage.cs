using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The idea is to create a Starbucks coffee shop.
 * Main ingredient of coffee is - DarkRoast,HouseBlend,Espresso,Decaf
 * It is supplemented with codiments -Milk,Mocha,Soy, Whip
*/
namespace DecoratorPattern
{
    /// <summary>
    /// Component
    /// </summary>
    public interface IBeverageComponent
    {
        string GetDescription();
        decimal Cost();
    }

    public class DarkRoastComponent : IBeverageComponent
    {
        public string GetDescription()
        {
            return "Dark Roast";
        }

        public decimal Cost()
        {
            return 10;
        }
    }

    public class HouseBlendComponent : IBeverageComponent
    {
        public string GetDescription()
        {
            return "HouseBlend";
        }

        public decimal Cost()
        {
            return 15;
        }
    }

    public class EspressoComponent : IBeverageComponent
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public decimal Cost()
        {
            return 20;
        }
    }
}
