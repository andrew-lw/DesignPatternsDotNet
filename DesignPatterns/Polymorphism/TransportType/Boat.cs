using Polymorphism.MovementType;

namespace Polymorphism.TransportType
{
    public class Boat : IAbstractTransportType
    {
        public override IMovementType MovementType { get => _type; }

        private IMovementType _type;

        public Boat()
        {
            _type = new Float();
        }
    }
}