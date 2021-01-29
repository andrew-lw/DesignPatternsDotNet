namespace Polymorphism.Transport
{
    public  class Jet : IAbstractTransport, TransportType.IPlane
    {
        public override ITransportType TransportType { get { return _transportType; } }
        public override string Manufacturer { get { return _make; } set { _make = value; } }
        public override string ModelName { get { return _model; } set { _model = value; } }
        public override int PassengerCapacity { get { return _seats; } set {if (value >= 0) _seats = value;} }
        public int MaxAltitude { get { return _maxAlt; } set { if (value >= 0) _maxAlt = value;} }

        private ITransportType _transportType;
        private string _make;
        private string _model;
        private int _seats;
        private int _maxAlt;

        public Jet()
        {
            _transportType = new TransportType.Plane();
        }

        public string DoABarrelRoll()
        {
            return "look mah no hands...";
        }
    }
}