# What Is Object-Oriented Programming (OOP)? And Why?

## 1. The Main Idea

**Object-Oriented Programming (OOP)** is a programming approach that organizes a program around **objects**. An object groups together:

- **Data (attributes/properties):** Information about the object.
- **Behavior (methods):** Actions the object can perform.

Instead of thinking only about a long list of functions, we think about the **things** in our system and what each thing **knows** and **does**.

> **Key idea:** The problem is not the number of functions. The problem is how we organize them and think about the system.

---

## 2. University System: A Function-Centered Approach

Imagine that we are developing a university management system. It needs many operations:

**Students**
- `AddStudent()`
- `UpdateStudent()`
- `DeleteStudent()`
- `CalculateAverage()`
- `EnrollStudentInCourse()`
- `UnEnrollStudentFromCourse()`

**Courses**
- `AddCourse()`
- `UpdateCourse()`
- `DeleteCourse()`
- `HowManyStudentsInCourse()`

**Professors and employees**
- `AssignCourseToDoctor()`
- `SendEmailToDoctor()`
- `AddEmployee()`
- `UpdateEmployee()`
- `DeleteEmployee()`
- `CalculateSalary()`
- `PaySalary()`

**Communication**
- `SendEmailToStudent()`
- `SendTextMessageToStudent()`
- `CallStudent()`
- `CallDoctor()`

A real system may have **hundreds or thousands of functions**.

Having many functions is **not automatically a problem**. The challenge is keeping the code **organized, understandable, and easy to maintain** as the system grows.

---

## 3. The OOP Approach

With OOP, we can organize our university system into related **classes** such as:

- `Student`
- `Course`
- `Professor` (or `Doctor` in the lecture)
- `Department`
- `Employee`
- `Major`
- `College`

Each class describes a type of thing in the system. Its objects contain relevant data and provide related behavior.

For example:

| Class | Example data | Example behavior |
|---|---|---|
| `Student` | Name, Email | Enroll in a course, calculate average |
| `Course` | ID, Name | Find enrolled students |
| `Professor` | Name, Salary | Teach a course |
| `Employee` | Name, Salary | Calculate salary |

**OOP groups related data and functionality together**, rather than treating every operation as a separate, unrelated part of the program.

---

## 4. Example: A Student Object

Suppose we create a student object named `student1`.

### Properties (Data)

```csharp
student1.Name;
student1.Email;
```

These describe the student.

### Methods (Behavior)

```csharp
student1.GetEnrolledCourses();
student1.CalculateAverage();
student1.SendEmail(subject, body);
student1.EnrollInCourse(10);
student1.UnEnrollFromCourse(10);
```

These describe actions associated with that student.

The expressions above are **illustrative method calls**, not a complete working program. The class and its methods must be implemented first.

### Class vs. Object

- **Class:** A blueprint describing the data and behavior of a type of thing, e.g., `Student`.
- **Object:** A particular instance created from the class, e.g., `student1`.

In C#:

```csharp
Student student1 = new Student();
```

Here, `Student` is the **class**, while `student1` refers to an **object** of that class.

---

## 5. Why Do We Use OOP?

1. **Organization:** Keep related properties and methods together.
2. **Readability:** Understand code by thinking in terms of real-world concepts like students and courses.
3. **Maintainability:** Find and modify related functionality more easily.
4. **Reusability:** Define a class once, then create multiple objects from it.
5. **Scalability of design:** Manage growing systems by separating responsibilities across classes.

### A simple analogy: Your contacts

Imagine having thousands of names and phone numbers without any organization. Finding one person's information would be difficult.

A contacts app organizes each person's details into a contact. Similarly, OOP helps organize software around related objects.

---

## 6. Function-Centered Programming vs. OOP

| Function-centered approach | Object-oriented approach |
|---|---|
| Focuses mainly on functions and procedures | Focuses on objects, their data, and behavior |
| Functions may operate on data passed to them | Related data and methods can be grouped into classes |
| Example: `CalculateAverage(student)` | Example: `student.CalculateAverage()` |
| Can still be well organized | Provides a natural way to organize code by related concepts |

**Important distinction:** The lecture labels the first approach **FP (Functional Programming)**, but its example mainly illustrates **function-centered/procedural organization**. Formal functional programming is a distinct paradigm and can also be well organized. OOP is not automatically better for every problem.

---

## 7. A Small University Example

Think about a student named Ali.

- Ali's **name** and **email** are properties.
- Ali's ability to **enroll in a course** and **calculate an average** is represented by methods.
- Another student, Sara, can be another object of the same `Student` class, with different property values.

This lets us represent many students using the same class definition instead of designing every student separately.

---

## 8. Key Terms

| Term | Meaning |
|---|---|
| **OOP** | Object-Oriented Programming |
| **Class** | A blueprint used to define objects |
| **Object** | An instance of a class |
| **Property / Attribute** | Data associated with an object |
| **Method** | A function associated with a class or object |
| **Instance** | A specific object created from a class |
| **Behavior** | What an object can do |
| **Maintainability** | How easily software can be changed and improved |
| **Reusability** | The ability to reuse existing code or designs |

## Quick Review

**Q: What is OOP?**  
A programming approach that organizes code around objects containing related data and behavior.

**Q: Why use OOP?**  
To help organize, understand, maintain, and reuse code in larger systems.

**Q: What is the difference between a class and an object?**  
A class is the blueprint; an object is an instance created from that blueprint.

**Remember:** OOP is about **how you organize your program**, not simply reducing the number of functions.
