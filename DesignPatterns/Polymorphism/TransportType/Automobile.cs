using Polymorphism.MovementType;

namespace Polymorphism.TransportType
{
    public class Automobile : IAbstractTransportType
    {
        public override IMovementType MovementType { get => _type; }

        private IMovementType _type;

        public Automobile()
        {
            _type = new Drive();
        }
    }
}