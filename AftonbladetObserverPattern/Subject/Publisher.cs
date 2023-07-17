using AftonbladetObserverPattern.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AftonbladetObserverPattern.Subject
{

    // The Publisher owns some important state and notifies observers when the
    // state changes.
    public class Publisher
    {
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Publisher: Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Publisher: Detached an observer.");
            _observers.Remove(observer);
        }


        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Publisher: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Publisher
        // can really do. Publishers commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void ReleaseNewMaterial()
        {
            Console.WriteLine("\nA new story has been released...");
            Notify();
        }
    }
}
