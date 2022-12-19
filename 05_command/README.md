# Command Design Pattern

## Objectives

Understanding the characteristics of the command pattern.

Implement the command pattern.

Understanding the benefits and tradeoffs.

## Definition

> The Command Pattern encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

## Characteristics

**Client** - decides what command to schedule (example: Button).

**ICommand** - defines the interface for the given command.

**Command** - a concrete implementation of the command (example: AddToCartCommand).

**Invoker** - invokes the command & keep tracks of commands (example: CommandManager).

**Receiver** - knows how to perform the operations associated with carrying out the command (example: ShoppingCart).

Client creates a command object and schedules it with the invoker.

Invoker executes the command.

Command object uses receiver to perform the operations.

A command object contains all the data to process the request now or at a later time.

## Benefits

The Command Pattern can easily be leveraged to allow undo or redo functionality.

A more extensible, object oriented and dynamic implementation.

Easier to add new commands.

Cleaner code.

Decouple your code and achieve a cleaner, more extensible code base.
