namespace Polymorphism.MovementType
{
    public abstract class IAbstractMovementType : IMovementType
    {
        public string Name { get => this.GetType().ToString(); }
        public virtual bool RequiresWheels { get; }
    }
}