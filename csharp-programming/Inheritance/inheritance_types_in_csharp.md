# Inheritance Types in C#

Inheritance lets a derived (child) class reuse and extend the members of a base (parent) class. In C#, a class can inherit from **one direct base class**.

The lecture shows five inheritance patterns:

| Type | Structure | Supported with C# classes? |
| --- | --- | --- |
| Single inheritance | `A → B` | ✅ Yes |
| Multilevel inheritance | `A → B → C` | ✅ Yes |
| Hierarchical inheritance | `A → B`, `A → C`, `A → D` | ✅ Yes |
| Multiple inheritance | `A + B → C` | ❌ No |
| Hybrid inheritance | Combination involving multiple class inheritance | ❌ Not in the form shown |

> **Important:** The ❌ signs refer to inheriting from **multiple classes**. C# *does* allow a class to implement multiple **interfaces**.

---

## 1. Single Inheritance ✅

One derived class inherits from one base class.

```text
A (Base)
   |
   v
B (Derived)
```

```csharp
class Person
{
    public string Name { get; set; }
}

class Employee : Person
{
    public decimal Salary { get; set; }
}
```

**Meaning:** `Employee IS-A Person`.

---

## 2. Multilevel Inheritance ✅

A class inherits from another derived class, creating a chain.

```text
A (Person)
   |
   v
B (Employee)
   |
   v
C (Manager)
```

```csharp
class Person
{
    public string Name { get; set; }
}

class Employee : Person
{
    public decimal Salary { get; set; }
}

class Manager : Employee
{
    public int TeamSize { get; set; }
}
```

**Meaning:** `Manager` inherits the accessible members of both `Employee` and `Person` through the inheritance chain.

---

## 3. Hierarchical Inheritance ✅

Multiple derived classes inherit from the **same base class**.

```text
         A (Person)
        /    |    \
       v     v     v
      B      C      D
   Student Employee Teacher
```

```csharp
class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    public string StudentNumber { get; set; }
}

class Employee : Person
{
    public decimal Salary { get; set; }
}

class Teacher : Person
{
    public string Subject { get; set; }
}
```

**Meaning:** Each child class inherits from `Person`, but the child classes do not automatically inherit from one another.

---

## 4. Multiple Inheritance ❌

A single class attempts to inherit directly from **two base classes**.

```text
A       B
 \     /
  v   v
    C
```

This is **not supported for classes** in C#:

```csharp
class A { }
class B { }

// Invalid C#: A class cannot inherit from two classes.
// class C : A, B { }
```

### Alternative: Multiple Interfaces ✅

C# allows a class to inherit from **one base class** and implement **multiple interfaces**:

```csharp
interface IPrintable
{
    void Print();
}

interface ISavable
{
    void Save();
}

class Document : IPrintable, ISavable
{
    public void Print() => Console.WriteLine("Printing...");
    public void Save() => Console.WriteLine("Saving...");
}
```

This is **multiple interface implementation**, not multiple class inheritance.

---

## 5. Hybrid Inheritance ❌ (as shown in the lecture)

Hybrid inheritance combines inheritance patterns. The diagram in the lecture has a **diamond-shaped** structure: `A` is inherited by both `B` and `C`, and `D` tries to inherit from **both** `B` and `C`.

```text
      A
     / \
    v   v
    B   C
     \ /
      v
      D
```

C# cannot express this pattern using **class inheritance**, because `D` would need two direct base classes.

You *can* combine supported patterns—for example, a multilevel hierarchy plus multiple interface implementations—but that is **not the same as the multiple-class-inheritance diamond in the slide**.

---

## Quick Review

- **Single:** One parent → one child. ✅
- **Multilevel:** A chain of inheritance. ✅
- **Hierarchical:** One parent → several children. ✅
- **Multiple:** One child → several **class** parents. ❌
- **Hybrid (diamond shown):** Combines patterns but requires multiple class parents. ❌
- **Interfaces:** A C# class can implement multiple interfaces. ✅

### Key Rule

> **C# supports single inheritance of classes, including multilevel and hierarchical arrangements, but it does not support multiple inheritance of classes.**

