# 04 - Abstraction in OOP

## 1. What Is Abstraction?

**Abstraction** is an Object-Oriented Programming (OOP) principle that exposes the essential features of an object while hiding unnecessary implementation details.

It focuses on **what an object can do**, rather than **how it does it internally**.

## 2. Simple Example

When you drive a car, you use the steering wheel, accelerator, and brakes. You do not need to understand every internal mechanism of the engine to drive it.

In programming, we can provide a simple set of methods while keeping their implementation details inside the relevant classes.

## 3. Abstraction in C#

C# supports abstraction in several ways, including **abstract classes** and **interfaces**.

An `abstract` class can define operations that derived classes must implement.

```csharp
using System;

namespace Abstraction
{
    abstract class PaymentMethod
    {
        // Abstract method: Derived classes must provide an implementation.
        public abstract void Pay(decimal amount);
    }

    class CardPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by card.");
        }
    }

    class CashPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} in cash.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod cardPayment = new CardPayment();
            cardPayment.Pay(100m);

            PaymentMethod cashPayment = new CashPayment();
            cashPayment.Pay(50m);

            // PaymentMethod payment = new PaymentMethod(); // Error: Abstract classes cannot be instantiated.
        }
    }
}
```

**Output:**

```text
Paid 100 by card.
Paid 50 in cash.
```

Both payment types expose the same operation, `Pay()`, but each implements it differently.

The caller only needs to know that it can call `Pay(amount)`.

## 4. Important C# Rules

- An **abstract class** cannot be instantiated directly.
- An **abstract method** declares an operation without providing a body.
- A non-abstract derived class must implement inherited abstract methods using `override`.
- An abstract class can also contain normal methods, fields, properties, and constructors.
- **Abstraction is a design principle**, not just the `abstract` keyword. Regular classes and methods can also provide abstraction by hiding their internal details.

## 5. Abstraction vs. Encapsulation

| Concept | Main Idea | Main Question |
|---|---|---|
| **Abstraction** | Expose essential operations and hide unnecessary complexity. | **What** can I do? |
| **Encapsulation** | Group data and behavior together and control access to internal state. | **How** is internal data protected and managed? |

They often work together, but they are **not the same concept**.

## 6. Why Use Abstraction?

- **Simplicity:** Users of a class do not need to understand all implementation details.
- **Flexibility:** Different classes can implement the same operation differently.
- **Maintainability:** Internal implementation can change without requiring callers to change, as long as the public contract stays the same.
- **Reusability:** Code can work with a common abstraction rather than a specific implementation.

## Summary

**Abstraction = Show what is necessary; hide unnecessary implementation details.**

In C#, `abstract` classes and interfaces are common tools for implementing abstraction.
