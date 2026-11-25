# 03 - Encapsulation in OOP

## 1. What Is Encapsulation?

**Encapsulation** is an Object-Oriented Programming (OOP) principle that groups related data (fields and properties) and behavior (methods) inside a class. It also helps control how the data is accessed and modified.

## 2. Example: Student Class

A `Student` class can contain:

**Data (Fields / Properties):**
- `Name`
- `Email`

**Methods:**
- `GetEnrolledCourses()`
- `CalculateAverage()`
- `SendEmail(subject, body)`
- `EnrollInCourse(courseId)`
- `PayFees()`
- `UnenrollFromCourse(courseId)`

These members represent information and operations related to a student.

## 3. Working with Objects

Each student object represents a specific student.

```csharp
Student student1 = new Student();

student1.Name = "Muhammed";
student1.Email = "student@example.com";

student1.EnrollInCourse(10);
```

When we call `student1.EnrollInCourse(10)`, the operation applies to `student1`. Other student objects have their own instance data.

## 4. Encapsulation in C#

```csharp
class Student
{
    // Private Field
    private int _enrolledCourses;

    // Public Properties
    public string Name { get; set; }
    public string Email { get; set; }

    // Public Method
    public void EnrollInCourse()
    {
        _enrolledCourses++;
    }

    // Public Method
    public int GetEnrolledCourseCount()
    {
        return _enrolledCourses;
    }
}
```

**Usage:**

```csharp
Student student1 = new Student();

student1.Name = "Muhammed";

student1.EnrollInCourse();
student1.EnrollInCourse();

Console.WriteLine(student1.GetEnrolledCourseCount());
// Output: 2

// student1._enrolledCourses = 100; // Error: Private field
```

The `_enrolledCourses` field is private, so code outside `Student` cannot change it directly. Instead, the class provides public methods to work with that data.

## 5. Why Use Encapsulation?

- **Organization:** Keep related data and methods together.
- **Data Protection:** Restrict direct access to internal fields.
- **Control:** Define how data can be changed.
- **Maintainability:** Change implementation details without necessarily changing how other code uses the class.

## 6. Important Notes

- A **class** defines data and behavior.
- An **object** is an instance of a class.
- Instance members operate on a specific object.
- `private` members cannot be accessed directly from outside the class.
- `public` properties and methods provide ways to interact with objects.

## Summary

**Encapsulation = Grouping data and methods together + controlling access to internal data.**

> The lecture slide emphasizes keeping a student's data and actions together in the `Student` class. The `private`/`public` code example also illustrates data hiding, another important part of encapsulation.
