namespace Polymorphism.MovementType
{
    public class Flight : IAbstractMovementType
    {
        public Flight()
        {
            _requiresWheels = false;
        }

        private bool _requiresWheels;

        public override bool RequiresWheels { get => _requiresWheels; }
    }
}