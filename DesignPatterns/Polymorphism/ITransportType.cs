namespace Polymorphism
{
    public interface ITransportType
    {
        public string Name { get; }
        public IMovementType MovementType { get; }
    }
}