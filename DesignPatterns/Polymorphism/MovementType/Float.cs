namespace Polymorphism.MovementType
{
    public class Float : IAbstractMovementType
    {
        public Float()
        {
            _requiresWheels = false;
        }

        private bool _requiresWheels;

        public override bool RequiresWheels { get => _requiresWheels; }
    }
}