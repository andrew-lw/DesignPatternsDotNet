namespace Polymorphism.Transport
{
    public class Car : IAbstractTransport
    {
        public override ITransportType TransportType { get { return _transportType; } }
        public override string Manufacturer { get { return _make; } set { _make = value; } }
        public override string ModelName { get { return _model; } set { _model = value; } }
        public override int PassengerCapacity { get { return _seats; } set { if (value >= 0) _seats = value; } }
        public int NumberOfDoors { get { return _doors; } set { if (value >= 0) _doors = value; } }

        private ITransportType _transportType;
        private string _make;
        private string _model;
        private int _seats;
        private int _doors;

        public Car(string make, string model, int nbrSeats = 5, int doors = 4)
        {
            _transportType = new TransportType.Automobile();
            _make = make ?? "unknown";
            _model = model ?? "unknown";
            _seats = nbrSeats;
            _doors = doors;

        }

        public Car()
        {
            _transportType = new TransportType.Automobile();
            _seats = 5;
            _doors = 4;
        }
    }
}
