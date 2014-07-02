using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace ObserverPatternTest
{
    [TestClass]
    public class PushObserverTests
    {
        [TestMethod]
        public void PushBasedObserverTest()
        {
            ICustomObservable<WeatherUpdates> observable = new PushTemperateObservable();
            ICustomObserver<WeatherUpdates> mobileObserver = new MobilePhoneTemperaturePushObserver();
            ICustomObserver<WeatherUpdates> billBoardObserver = new BillBoardTemperaturePushObserver();
            observable.AddObserver(mobileObserver);
            observable.AddObserver(billBoardObserver);

            observable.Update(new WeatherUpdates {Humidity = 100, Temperature = 35});
            observable.Update(new WeatherUpdates { Humidity = 90, Temperature = 30 });
        }
    }
}
