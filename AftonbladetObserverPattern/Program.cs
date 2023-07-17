using AftonbladetObserverPattern.Observers;
using AftonbladetObserverPattern.Subject;

namespace AftonbladetObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var publisher = new Publisher();
            var observerA = new Richard();
            publisher.Attach(observerA);

            var observerB = new Linda();
            publisher.Attach(observerB);

            var observerC = new Alicia();
            publisher.Attach(observerC);

            // Övning 1
            publisher.ReleaseNewMaterial();

            // Övning 2
            publisher.Detach(observerC);

            // Övning 3
            var observerD = new Stefan();
            publisher.Attach(observerD);

            // Övning 4
            publisher.ReleaseNewMaterial();
        }
    }
}