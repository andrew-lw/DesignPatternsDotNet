namespace Polymorphism.Transport
{
    public class TugBoat : IAbstractTransport
    {
        public override ITransportType TransportType { get { return _transportType; } }
        public override string Manufacturer { get { return _make; } set { _make = value; } }
        public override string ModelName { get { return _model; } set { _model = value; } }
        public override int PassengerCapacity { get { return _capacity; } set { if (value >= 0) _capacity = value; } }
        public bool HasCrane {  get { return _hasCrane;  } set { _hasCrane = value; } }

        private ITransportType _transportType;
        private string _make;
        private string _model;
        private int _capacity;
        private bool _hasCrane;

        public TugBoat(string make, string model, int passengerCapacity, bool hasCrane = false)
        {
            _transportType = new TransportType.Boat();
            _make = make ?? "unknown";
            _model = model ?? "unknown";
            _capacity = passengerCapacity;
            _hasCrane = hasCrane;
        }
    }
}