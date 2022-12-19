# Command Design Pattern

## Objectives

Understanding the characteristics of the command pattern.

Implement the command pattern.

Understanding the benefits and tradeoffs.

## Definition

> The Command Pattern encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

## Characteristics

**ICommand** - defines the interface for the given command.

**Command** - a concrete implementation of the command.

**Invoker** - invokes the command.

**Receiver** - knows how to perform the operations associated with carrying out the request.

## Benefits

A more extensible, object oriented and dynamic implementation.

Easier to add new commands.

Cleaner code.

Decouple your code and achieve a cleaner, more extensible code base.
