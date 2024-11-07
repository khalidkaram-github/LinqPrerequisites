namespace LinqPrerequisites
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly Typed Local Variables
            var number = 10;         // Compiler infers as int
            var message = "Hello!";  // Compiler infers as string
            var isActive = true;     // Compiler infers as bool

            Console.WriteLine(number);    // Output: 10
            Console.WriteLine(message);   // Output: Hello!
            Console.WriteLine(isActive);  // Output: True
            #endregion

            #region Object/Collection Initialization Syntax
            // Object Initialization
            var person = new Person { Name = "Alice", Age = 25 };



            Console.WriteLine($"{person.Name}, {person.Age}"); // Output: Alice, 25

            // Collection Initialization
            var people = new List<Person>
            {
                new Person { Name = "hamza", Age = 0 },
                new Person { Name = "eslam", Age = 28 },
                new Person { Name = "zidan", Age = 27 }
            };
            foreach (var persosn in people)
            {
                Console.WriteLine(person.Name);  // Output: hamza , eslam , zidan
            }
            #endregion

            #region Lambda Expressions & anonymous function

            // Lambda to square a number
            Func<int, int> square = x => x * x;

            Console.WriteLine(square(5)); // Output: 25

            #endregion

            #region Extension Methods

            string text = "hello";
            Console.WriteLine(text.Capitalize()); // Output: Hello

            #endregion

            #region Anonymous Types
            var product = new { Name = "Laptop", Price = 1200.99 };
            Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
            // Output: Product: Laptop, Price: $1200.99
            #endregion

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
