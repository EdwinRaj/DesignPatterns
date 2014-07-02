using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    public interface ICustomObserver<in T>
    {
        void Update(T updates);
    }

    public interface ICustomObservable<T>
    {
        void AddObserver(ICustomObserver<T> observer);
        void RemoveObserver(ICustomObserver<T> observer);
        void NotifyObserver();
        void Update(T updates);
    }

    public class WeatherUpdates
    {
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }  
    }

    /// <summary>
    /// This class is also knownas the subject
    /// </summary>
    public class PushTemperateObservable:ICustomObservable<WeatherUpdates>
    {
        readonly List<ICustomObserver<WeatherUpdates>> _observerCollection = new List<ICustomObserver<WeatherUpdates>>();
        private WeatherUpdates _weatherUpdates;

        public void AddObserver(ICustomObserver<WeatherUpdates> observer)
        {
            _observerCollection.Add(observer);    
        }

        public void RemoveObserver(ICustomObserver<WeatherUpdates> observer)
        {
            _observerCollection.Remove(observer);
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

    public class MobilePhoneTemperaturePushObserver : ICustomObserver<WeatherUpdates>
    {
        public void Update(WeatherUpdates updates)
        {
            Console.WriteLine("I am mobile Phone observer. Current Temperature {0} and Humidity {1}",updates.Temperature,updates.Temperature);
        }
    }

    public class BillBoardTemperaturePushObserver : ICustomObserver<WeatherUpdates>
    {
        public void Update(WeatherUpdates updates)
        {
            Console.WriteLine("I am Bill Board observer. Current Temperature {0} and Humidity {1}", updates.Temperature, updates.Temperature);
        }
    }
}
