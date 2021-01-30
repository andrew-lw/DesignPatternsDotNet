Software Design Patterns & Principles
=====================================

This project illustrates various software design concepts using C#. The README file attempts to explain the reason for the concept/pattern, why other solutions are inferior and how to implement it. The Tests portion of the solution proves the solution works as expected.  

* [Polymorphism](#Polymorphism)
* [Encapsulation](#encapsulation)
* [Inheritance](#inheritance)
* [Single Responsibility Principle](#singleResponsibility)
* [Open/Closed Principle](#openclose)
* [Liskov Substitution Principle](#liskov)
* [Interface Segregation Principle](#interfaceSegregation)
* [Dependency Inversion](#dependencyInversion)
* [Factory](#factory)
* [Abstract Factory](#abstractFactory)
* [Singleton](#singleton)
* [Decorator](#decorator)
* [Iterator](#iterator)
* [Observer](#observer)
* [Repository](#repository)
* [Unit of Work](#unitOfWork)
* [Builder](#builder)
* [Adapter](#adapter)
* [Composite](#composite)
* [Chain of responsibility](#chain)
* [Command](#command)
* [Interpreter](#interpreter)
* [Mediator](#mediator)
* [Visitor](#visitor)

Why Learn Design Patterns?
--------------------------

Design patterns attempt to address common software design problems with common solutions. Loading a dishwasher can be done many different (and even creative) ways. There are more optimal, easier and commonly ways to do it which usually produce the best outcomes. So it with software design concepts. Learning them will make you a better developer, better mentor and free your mind up to do more important things like loading the dishwasher properly.  

### Polymorphism

One of the 3 pillars of object oriented programming. Allows for seperation of classes, their properties and methods from the user of that functionalilty for the purpose of different implementations. The example used in the solution is different types of transports. At compile it is not necessary to know if something is car or plane. Just that it derives from the transport base class. With that knowledge you know that no matter the specific type chosen some things are common : it has an engine of some kind, seats, it can perform some type of movement, etc. The core of the concept is captured in the below example.

```cs
public abstract class ITransport 
{
    public int FuelTankGallons {get; set;}

    public abstract Move();

    public virtual float GetRemainingFuelPct(){
        return 50.3f;
    }
}

public class Car : ITransport {
    //car is required to implement move
    public Move(){
        //vroom...
    }
    //car can override GetTransportType() but chooses not to

}

public class Plane : ITransport {
    //plane is required to implement move
    public  Move(){
        //we have lift off
    }
    //plane can override GetTransportType() and does changing it's behavior
    public override float GetRemainingFuelPct(){

        return 97.1f;
    }
}
```
