# Singleton Design Pattern

## Objectives

What problems can the Singleton design pattern solve?

How is the Singleton design pattern structured?

Apply the pattern in real code.

Alternatives and related patterns.

## Definition

A singleton is a class designed to only ever have one instance.

Examples of singletons include:

- access to file system,
- access to shared network resources,
- expensive one-time configuration.

## Singleton structure

At any time, only 0 or 1 instance of the Singleton class exists in the application.

Singleton classes are created without parameters.

Assume lazy instantiation as the default.

A single, private parameterless constructor.

Sealed.

A private static field holds the only reference to the instance.

A public static method provides access to this field.

## Singleton implementations

Naive implementation is not thread safe, if block can be reached by multiple threads concurrently, resulting in multiple instantiations of Singleton.

Ideas how to create a thread safe singleton can be found [here](https://web.archive.org/web/20080713050413/http://www.yoda.arachsys.com/csharp/singleton.html).

We can use locking or static initialization, but preferred way is to use the .NET 4.0 Lazy\<T\> class.

## Antipattern?

Difficult to test due to shared state.

Doesn't follow Separation of Concerns.

Doesn't follow Single Responsibility Principle.

Doesn't follow DRY.

Better alternatives exist.

## Alternatives

Static class, but remember about differences.

Best practice is to use dependency injection.

Singleton behavior can be achieved using containers (DI containers).

> Manage lifetime using container, not class design.
