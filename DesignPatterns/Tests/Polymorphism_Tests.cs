using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism.Transport;
using Polymorphism;
using Polymorphism.MovementType;
using Polymorphism.TransportType;

namespace Tests
{
    [TestClass]
    public class Polymorphism_Tests
    {
        [TestMethod]
        public void Car_Constructor_OnlyRequiredParameters_UsesDefaultValuesForCar()
        {
            Assert.AreEqual(4, _car.NumberOfDoors);
            Assert.AreEqual(5, _car.PassengerCapacity);
        }

        [TestMethod]
        public void Car_BaseType_IsIAbstractTransportType()
        {
            Assert.AreEqual(typeof(IAbstractTransport), _car.GetType().BaseType);
        }

        [TestMethod]
        public void Car_Type_IsITransportInterface()
        {
            Assert.IsTrue(_car is ITransport);
        }

        [TestMethod]
        public void Car_ITransport_ConvertsImplictly()
        {
            Assert.IsTrue(_car is Car);
            Assert.IsTrue(_car is ITransport);
        }

        [TestMethod]
        public void Car_Properties_HasSpecificCarProperties()
        {
            Assert.AreEqual(4, _car.NumberOfDoors);
            Assert.AreEqual(5, _car.PassengerCapacity);
        }

        [TestMethod]
        public void Car_TransportType_IsITransportTypeAndAutomobile()
        {
            Assert.IsTrue(_car.TransportType is ITransportType);
            Assert.IsTrue(_car.TransportType is Automobile);
        }

        [TestMethod]
        public void Car_MovementType_IsDrive()
        {
            Assert.IsTrue(_car.TransportType.MovementType is IMovementType);
            Assert.IsTrue(_car.TransportType.MovementType is Drive);
            Assert.AreEqual("Polymorphism.MovementType.Drive",_car.TransportType.MovementType.Name);
        }

        [TestMethod]
        public void Car_BaseMethods_AlterSubclassState()
        {
            Assert.IsFalse(_car.InMotion);
            _car.StartMoving();
            Assert.IsTrue(_car.InMotion);
            _car.StopMoving();
            Assert.IsFalse(_car.InMotion);
        }

        [TestMethod]
        public void Car_PropertyTypes_MatchTruckPropertyTypes()
        {
            Assert.AreEqual(_car.TransportType.GetType(), _truck.TransportType.GetType());
            Assert.AreEqual(_car.TransportType.MovementType.GetType(), _truck.TransportType.MovementType.GetType());
        }

        [TestMethod]
        public void Car_PropertyDefaults_AreDifferentThanTruckDefaults()
        {
            Assert.AreNotEqual(_car.NumberOfDoors, _truck.NumberOfDoors);
            Assert.AreNotEqual(_car.PassengerCapacity, _truck.PassengerCapacity);
        }

        [TestMethod]
        public void Jet_BaseType_IsInterfaceAndAbstractType()
        {
            Assert.IsTrue(_jet is ITransport);
            Assert.IsTrue(_jet is IAbstractTransport);
        }

        [TestMethod]
        public void Jet_HasUniquePropertiesOnlyForPlane()
        {
            Assert.AreEqual(0,_jet.MaxAltitude);
        }

        [TestMethod]
        public void Jet_Methods_HasUniqueMethodOnlyForIPlane()
        {
            Assert.AreEqual("look mah no hands...", _jet.DoABarrelRoll());
        }


        [TestInitialize]
        public void Init()
        {
            _car = new Car();
            _truck = new Truck();
            _jet = new Jet();
        }

        private Car _car;
        private Truck _truck;
        private Jet _jet;
    }
}