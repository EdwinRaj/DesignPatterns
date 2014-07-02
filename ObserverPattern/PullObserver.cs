using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class VegetableMarketPrice
    {
        public decimal OnionPrice { get; set; }
        public decimal PotatoPrice { get; set; }
        public decimal TomatoPrice { get; set; }

        public override string ToString()
        {
            return string.Format("Onion Price:{0}   Potato Price:{1}    TomatoPrice:{2}", OnionPrice, PotatoPrice,
                TomatoPrice);
        }
    }

    public class VegetableMarketPullObservable:ICustomPullObservable<VegetableMarketPrice>
    {
        readonly List<ICustomPullObserver<VegetableMarketPrice>> _priceObservers = new List<ICustomPullObserver<VegetableMarketPrice>>();

        private VegetableMarketPrice _marketPrice = null;

        public VegetableMarketPullObservable()
        {
            _marketPrice = new VegetableMarketPrice();
        }

        public void AddObserver(ICustomPullObserver<VegetableMarketPrice> pushObserver)
        {
            _priceObservers.Add(pushObserver);    
        }

        public void RemoveObserver(ICustomPullObserver<VegetableMarketPrice> pushObserver)
        {
            _priceObservers.Remove(pushObserver);
        }

        public void Update(VegetableMarketPrice updates)
        {
            _marketPrice = updates;
        }

        public VegetableMarketPrice ObservableState { get { return _marketPrice; } }
    }

    public class HotelPullObserver : ICustomPullObserver<VegetableMarketPrice>
    {
        private readonly ICustomPullObservable<VegetableMarketPrice> _vegMarketobservable;

        public HotelPullObserver(ICustomPullObservable<VegetableMarketPrice> observable )
        {
            _vegMarketobservable = observable;
            _vegMarketobservable.AddObserver(this);
        }

        public void ShowUpdates()
        {
            Console.Write("I am hotel Observer");
            Console.WriteLine( _vegMarketobservable.ObservableState.ToString() );
        }
    }

    public class HomePullObserver : ICustomPullObserver<VegetableMarketPrice>
    {
        private readonly ICustomPullObservable<VegetableMarketPrice> _vegMarketobservable;

        public HomePullObserver(ICustomPullObservable<VegetableMarketPrice> observable)
        {
            _vegMarketobservable = observable;
            _vegMarketobservable.AddObserver(this);
        }

        public void ShowUpdates()
        {
            Console.Write("I am hotel Observer");
            Console.WriteLine(_vegMarketobservable.ObservableState.ToString());
        }
    }
}
