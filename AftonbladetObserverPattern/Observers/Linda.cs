using AftonbladetObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AftonbladetObserverPattern.Observers
{
    class Linda : IObserver
    {
        public void Update(Publisher pub)
        {
            Console.WriteLine("Linda: Thanks for the story.");
        }
    }
}
