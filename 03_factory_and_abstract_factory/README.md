# Factory Design Pattern

## Objectives

Understanding the characteristics of the factory patterns.

Implement the factory pattern.

Understanding the benefits and tradeoffs.

## Definition

> A factory is an object for creating objects.

Factory pattern flavors:

- Simple Factory,
- Factory Method,
- Abstract Factory.

## Characteristics

**Client** - asks for a created product.

**Creator** - facilitates a creation.

**Product** - the product of the creation.

The client no longer needs to know hot to create an object or exactly what flavor of that class it will use.

## Simple Factory

The simplest factory pattern.

Using factory method is a more extensible alternative.

Introduce a factory to make code in the application more reusable.

## Factory Method

The factory pattern is introduced to allow for a flexible and extensible application.

Extend the creator to override the default factory method.

A powerful pattern that makes your application code more reusable and extensible.

In many cases the _simple factory_ and _factory method_ will be sufficient.

## Abstract Factory

> The Abstract Factory Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.

The abstract factory pattern is a factory of factories.
