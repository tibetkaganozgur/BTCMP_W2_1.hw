using System;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ali works at the lobby, he should says "greetings" to every customer.
            var employee = new Person { Name = "Ali", Age = 20};
            var customer = new Person {Name = "Veli", Age = 30};

            //Extension Method Usage:
            employee.GreetCustomers(customer);
        }
    }
    
    //Extension method:
    public static class Extensions
    {
        public static void GreetCustomers(this Person person, Person person2)
        {
            Console.WriteLine("{0} says: 'Greetings Sir' to {1}", person.Name, person2.Name);
        }
    }
}
