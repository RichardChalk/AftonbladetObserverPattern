using AftonbladetObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AftonbladetObserverPattern.Observers
{
    public interface IObserver
    {
        // Receive update from publisher
        void Update(Publisher publisher);
    }
}
