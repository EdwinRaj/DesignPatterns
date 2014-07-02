using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherUpdates
    {
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }  
    }

    /// <summary>
    /// This class is also knownas the subject
    /// </summary>
    public class PushTemperatePushObservable:ICustomPushObservable<WeatherUpdates>
    {
        readonly List<ICustomPushObserver<WeatherUpdates>> _observerCollection = new List<ICustomPushObserver<WeatherUpdates>>();
        private WeatherUpdates _weatherUpdates;

        public void AddObserver(ICustomPushObserver<WeatherUpdates> pushObserver)
        {
            _observerCollection.Add(pushObserver);    
        }

        public void RemoveObserver(ICustomPushObserver<WeatherUpdates> pushObserver)
        {
            _observerCollection.Remove(pushObserver);
        }

        
        public void NotifyObserver()
        {
            _observerCollection.ForEach(x=>x.Update(_weatherUpdates));
        }

        public void Update(WeatherUpdates updates)
        {
            _weatherUpdates = updates;
            NotifyObserver();
        }
    }

    public class MobilePhoneTemperaturePushPushObserver : ICustomPushObserver<WeatherUpdates>
    {
        public void Update(WeatherUpdates updates)
        {
            Console.WriteLine("I am mobile Phone observer. Current Temperature {0} and Humidity {1}",updates.Temperature,updates.Humidity);
        }
    }

    public class BillBoardTemperaturePushPushObserver : ICustomPushObserver<WeatherUpdates>
    {
        public void Update(WeatherUpdates updates)
        {
            Console.WriteLine("I am Bill Board observer. Current Temperature {0} and Humidity {1}", updates.Temperature, updates.Humidity);
        }
    }
}
