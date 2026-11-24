# Objects in Memory

## 1. What Is an Object?

An **object** is an **instance of a class**.

A **class** defines a data type and describes the **fields** (data) and **methods** (behavior) that its objects can have. We can create multiple objects from the same class.

For example:

```text
            Student (Class)
                  |
       +----------+----------+
       |          |          |
   Student1    Student2    Student3
   (Object)    (Object)    (Object)
```

All three objects are instances of `Student`, but each can hold different data.

## 2. Each Object Has Its Own Data in Memory

When you create several instances of a class, **each instance has its own storage for its instance fields**.

Consider this C# class:

```csharp
class clsPerson
{
    // Fields (data members)
    public string FirstName;
    public string LastName;

    // Method (member function)
    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}
```

Now create two objects:

```csharp
clsPerson person1 = new clsPerson();
person1.FirstName = "Muhammed";
person1.LastName = "El Mahmod";

clsPerson person2 = new clsPerson();
person2.FirstName = "Ali";
person2.LastName = "Maher";

Console.WriteLine(person1.FullName());
Console.WriteLine(person2.FullName());
```

**Output:**

```text
Muhammed El Mahmod
Ali Maher
```

Conceptually, their data looks like this:

```text
       clsPerson (Class)
       FullName() method
              |
     +--------+--------+
     |                 |
  person1            person2
  FirstName:         FirstName:
  "Muhammed"          "Ali"
  LastName:          LastName:
  "El Mahmod"         "Maher"
```

Even though both objects were created using the same class, their instance fields are **independent**.

For example:

```csharp
person1.FirstName = "Ahmed";
```

This changes **only `person1`**. The first name of `person2` remains `"Ali"`.

## 3. Member Functions Are Shared

The lesson emphasizes an important distinction:

- **Data members (instance fields):** Each object has its own values.
- **Member functions (instance methods):** Objects use the same method definition written in the class.

For example, both `person1.FullName()` and `person2.FullName()` call the `FullName()` method defined in `clsPerson`. The method works with the fields of **the object it was called on**.

**Important:** Saying methods are "shared" here means the method's code is not separately defined for every object. It does **not** mean that the objects share their `FirstName` or `LastName` values.

## 4. Class vs. Object vs. Instance

| Term | Meaning |
|---|---|
| **Class** | A template that defines fields and methods. |
| **Object** | A concrete instance created from a class. |
| **Instance** | Another word for an object created from a class. |
| **Field / Data Member** | A variable belonging to a class or object. |
| **Method / Member Function** | A function defined inside a class. |
| **`new`** | Creates a new object of the class. |

## 5. Quick Review

1. Can one class be used to create many objects? **Yes.**
2. Do `person1` and `person2` have the same fields? **Yes, as defined by `clsPerson`.**
3. Do they have to contain the same field values? **No.**
4. If you update `person1.FirstName`, does `person2.FirstName` change? **No.**
5. Does each object need its own separately written `FullName()` method? **No. Both use the method defined by the class.**

> **Remember:** **One class → many objects. Each object has its own instance data; the method definition is reused.**
