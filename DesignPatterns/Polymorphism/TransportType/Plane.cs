using Polymorphism.MovementType;

namespace Polymorphism.TransportType
{
    public class Plane : IAbstractTransportType
    {
        public override IMovementType MovementType { get => _type; }

        private IMovementType _type;

        public Plane()
        {
            _type = new Flight();
        }
    }
}