namespace Polymorphism.MovementType
{
    public class CustomMovementType : IAbstractMovementType
    {
        public CustomMovementType()
        {
            _requiresWheels = false;
        }

        private bool _requiresWheels;

        public override bool RequiresWheels { get => _requiresWheels; }
    }
}