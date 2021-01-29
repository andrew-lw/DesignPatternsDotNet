namespace Polymorphism.MovementType
{
    public class Drive : IAbstractMovementType
    {
        public Drive()
        {
            _requiresWheels = true;
        }

        private bool _requiresWheels;

        public override bool RequiresWheels { get => _requiresWheels; }
    }
}