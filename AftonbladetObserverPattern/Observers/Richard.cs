using AftonbladetObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AftonbladetObserverPattern.Observers
{
    // Concrete Observers react to the updates issued by the Publisher they had
    // been attached to.
    class Richard : IObserver
    {
        public void Update(Publisher pub)
        {
            Console.WriteLine("Richard: Thanks for the story.");
        }
    }

}
