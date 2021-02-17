Software Design Patterns & Principles
=====================================

This project illustrates various software design concepts using C#.

What are design patterns and why use them?
------------------------------------------

Design patterns attempt to address common software problems with a set of common design solutions. Take regrouping in addition as a simple example. For problems requiring two digit addition and subtraction there are common [STRATEGIES](https://elementarynest.com/teaching-strategies-for-2-digit-addition-and-subtraction/) to getting the answer. These are not exhuastive by any means but they show in simple mathmatics what software design patterns attempt to do with software design : create a quality, reusable solution to a common problem. Not only does this make sense for the person doing the math problem to very often use the same method across multiple problem sets but it also allows for reuse across students and teachers as well. The added benefit of this is a shared vocabulary and understanding. All the 2nd grade teachers can discuss a given strategy by name without having to explain what that is. They can even discuss which strategy works best for their school district and why. You could then bring in a new teacher who knows nothing of your school district and tell them we are using the "open number line" strategy to teach two digit addition and subtraction and they would know exactly what you are referring to.

- [Creational](#Creational) - patterns for creating objects
  - [Factory](#Factory)
  - [Abstract Factory](#abstractFactory)
  - [Singleton](#singleton)
  - [Builder](#builder)
  - [Prototype](#prototype)
- [Structural](#Structural) - object composition, relationship between objects
  - [Decorator](#decorator)
  - [Adapter](#adapter)
  - [Composite](#composite)
  - [Facade](#facade)
  - [Flyweight](#flyweight)
  - [Proxy](#proxy)
- [Behavioral](#Behavioral) - communication between objects
  - [Iterator](#iterator)
  - [Observer](#observer)
  - [Chain of responsibility](#chain)
  - [Command](#command)
  - [Interpreter](#interpreter)
  - [Mediator](#mediator)
  - [Visitor](#visitor)

### Factory Method

`Define an interface for creating an object, but let subclasses decide which class to instantiate.`

Very often in programming a need will arise for several subclasses to exist under one superclass or interface. The subclasses often exist as types of that superclass. I.e. A remote superclass with game remote, TV remote, RC remote all as subclasses. Additionally, it is clear that not all implementations of the superclass can be known whent the system is first being designed. Using a factory method can help make the code more extensible by avoiding tight coupling to concrete objects.