namespace Polymorphism
{
    public interface ITransport
    {
        public ITransportType TransportType { get;  }
        public string Manufacturer { get; set; }
        public string ModelName { get; set; }
        public bool InMotion { get; set; }
        public int PassengerCapacity { get; set; }

        public void StartMoving();
        public void StopMoving(); 

    }
}