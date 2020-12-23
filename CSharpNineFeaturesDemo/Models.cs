using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNineFeaturesDemo
{
    /// <summary>
    /// This is a record type
    /// Equality takes place on each property of this record
    /// built-in implemented methods are GetHashCode, Copy&Clone members, ToString()
    /// </summary>
    public record Employee
    {
        public int Id { get; }
        public string Name { get; }

        public Employee(int id, string name) => (Id, Name) = (id, name);
    }


    /// <summary>
    /// There is an implicit property being created with the record called EqualityContract with type Type. this property ensures that
    /// Employee will not be equal to Manager
    /// </summary>
    public record Manager: Employee
    {
        public string Department { get; }
        public Manager(int id, string name, string department) : base(id, name) => Department = department;
        public Manager(Employee employee, string department) : base(employee) => Department = department;
    }


    /// <summary>
    /// Records can have its own implementation of any method except Clone.
    /// Once we provide an implementation for a synthesized method, the compiler will not provide his.
    /// </summary>
    public record Person(string FirstName, string LastName); // Short syntax
    public record Teacher(string FirstName, string LastName, string Subject): Person(FirstName, LastName);


    public class Log
    {
        public int Id { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}
