namespace Polymorphism.TransportType
{
    public abstract class IAbstractTransportType : ITransportType
    {
        public string Name { get => this.GetType().ToString(); }

        public abstract IMovementType MovementType { get; }

    }
}