using Polymorphism.TransportType;

namespace Polymorphism.Transport
{
    public class PropellerPlane : IAbstractTransport, IPlane
    {
        public override ITransportType TransportType { get { return _transportType; } }
        public override string Manufacturer { get { return _make; } set { _make = value; } }
        public override string ModelName { get { return _model; } set { _model = value; } }
        public override int PassengerCapacity { get { return _seats; } set { if (value >= 0) _seats = value; } }
        public int MaxAltitude { get { return _maxAlt; } set { if (value >= 0) _maxAlt = value; } }
        public string BladType { get { return _propBladeType; } set { _propBladeType = value; } }

        private ITransportType _transportType;
        private string _make;
        private string _model;
        private int _seats;
        private int _maxAlt;
        private string _propBladeType;

        public PropellerPlane()
        {
            _transportType = new TransportType.Plane();
            _propBladeType = "carbonfiber";
        }

        public string DoABarrelRoll()
        {
            return "slow and steady gets you to charlotte for a layover";
        }
    }
}