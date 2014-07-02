using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace ObserverPatternTest
{
      [TestClass]
    public class PullObserverTests
    {
          [TestMethod]
          public void TestPullObserver()
          {
              ICustomPullObservable<VegetableMarketPrice> vegMarketObservable = new VegetableMarketPullObservable();
              ICustomPullObserver<VegetableMarketPrice> homeObserver = new HomePullObserver(vegMarketObservable);
              ICustomPullObserver<VegetableMarketPrice> hotelObserver  = new HotelPullObserver(vegMarketObservable);

              homeObserver.ShowUpdates();
              hotelObserver.ShowUpdates();

              Console.WriteLine("Changing the price");
              vegMarketObservable.Update(new VegetableMarketPrice {OnionPrice = 10, PotatoPrice = 20, TomatoPrice = 30});
              homeObserver.ShowUpdates();
              hotelObserver.ShowUpdates();


          }
    }
}
