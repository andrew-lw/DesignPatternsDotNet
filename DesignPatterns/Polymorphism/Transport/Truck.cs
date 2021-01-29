namespace Polymorphism.Transport
{
    public class Truck : IAbstractTransport
    {
        public override ITransportType TransportType { get { return _transportType; } }
        public override string Manufacturer { get { return _make; } set { _make = value; } }
        public override string ModelName { get { return _model; } set { _model = value; } }
        public override int PassengerCapacity { get { return _seats; } set { if (value >= 0) _seats = value; } }
        public int NumberOfDoors { get { return _doors; } set { if (value >= 0) _doors = value; } }
        public int BedLength { get { return _bedLength; } set { if (value >= 0) _bedLength = value; } }

        private ITransportType _transportType;
        private string _make;
        private string _model;
        private int _seats;
        private int _doors;
        private int _bedLength;

        public Truck()
        {
            _transportType = new TransportType.Automobile();
            _seats = 2;
            _doors = 2;
        }
    }
}