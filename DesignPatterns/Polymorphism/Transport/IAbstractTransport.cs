namespace Polymorphism.Transport
{
    public abstract class IAbstractTransport : ITransport
    {
        public abstract ITransportType TransportType { get; }
        public abstract string Manufacturer { get; set; }
        public abstract string ModelName { get; set; }
        public bool InMotion { get; set; }
        public abstract int PassengerCapacity { get; set; }

        public void StartMoving()
        {
            InMotion = true;
        }

        public void StopMoving()
        {
            InMotion = false;
        }
    }
}
