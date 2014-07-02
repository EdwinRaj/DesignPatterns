using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ICustomPushObserver<in T>
    {
        void Update(T updates);
    }

    public interface ICustomPullObserver<in T>
    {
        void ShowUpdates();
    }
}
