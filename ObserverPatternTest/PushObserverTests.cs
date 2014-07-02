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
            ICustomPushObservable<WeatherUpdates> pushObservable = new PushTemperatePushObservable();
            ICustomPushObserver<WeatherUpdates> mobilePushObserver = new MobilePhoneTemperaturePushPushObserver();
            ICustomPushObserver<WeatherUpdates> billBoardPushObserver = new BillBoardTemperaturePushPushObserver();
            pushObservable.AddObserver(mobilePushObserver);
            pushObservable.AddObserver(billBoardPushObserver);

            pushObservable.Update(new WeatherUpdates {Humidity = 100, Temperature = 35});
            pushObservable.Update(new WeatherUpdates { Humidity = 90, Temperature = 30 });

            Console.WriteLine("Removing Mobile Phone Observer");
            pushObservable.RemoveObserver(mobilePushObserver);
            pushObservable.Update(new WeatherUpdates { Humidity = 80, Temperature = 30 });

        }
    }
}
