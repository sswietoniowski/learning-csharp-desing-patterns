# Strategy Design Pattern

## Objectives

Understanding the characteristics of the strategy pattern.

Implement the strategy pattern.

Understanding the benefits and tradeoffs.

## Definition

> The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Characteristics

**Context** - has a reference to a strategy and invokes it.
**IStrategy** - defines the interface for the given strategy.
**Strategy** - a concrete implementation of the strategy.

Select an implementation at runtime based on user input without having to extend the class.

## Benefits

A more extensible, object oriented and dynamic implementation.

Easier to add new strategies.

Cleaner code.

Decouple your code and achieve a cleaner, more extensible code base.

Whenever you inject an interface to allow change of behavior you are leveraging the strategy pattern.
