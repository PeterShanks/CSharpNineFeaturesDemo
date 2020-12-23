using System;

namespace CSharpNineFeaturesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new(1, "John Doe");
            Manager manager1 = new Manager(employee1, "Accounting");
            Console.WriteLine(employee1);
            Console.WriteLine(manager1);
            Console.WriteLine(manager1 == employee1); // False due to EqualityContract property

            Console.WriteLine();

            var person = new Person("Peter", "Emad");
            var (first, last) = person;
            Console.WriteLine(first);
            Console.WriteLine(last);

            Console.WriteLine();

            var brother = person with { FirstName = "John" };
            Console.WriteLine(person);
            Console.WriteLine(brother);

            Console.WriteLine();

            Log log = new Log { Id = 1, CreatedAt = DateTime.Now };
            // log.CreatedAt = DateTime.Now.AddDays(5); // Error

            if (log is not null)
                Console.WriteLine(log.Id);
        }
    }
}
