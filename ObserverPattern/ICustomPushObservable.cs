using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ICustomPushObservable<T>
    {
        void AddObserver(ICustomPushObserver<T> pushObserver);
        void RemoveObserver(ICustomPushObserver<T> pushObserver);
        void NotifyObserver();
        void Update(T updates);
    }

    public interface ICustomPullObservable<T>
    {
        void AddObserver(ICustomPullObserver<T> pushObserver);
        void RemoveObserver(ICustomPullObserver<T> pushObserver);
        void Update(T updates);
        T ObservableState { get; }

    }
}
