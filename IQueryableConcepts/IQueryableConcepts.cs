using System;
using System.Collections.Generic;
using System.Linq;

namespace IQueryableExample
{
    // Definition:
    // The IQueryable interface is used to work with collections that support LINQ queries.
    // It is part of the System.Linq namespace and allows you to filter, sort, and transform data using LINQ.
    // It supports deferred execution, meaning the query is only executed when the data is accessed.

    // Example 1: Basic IQueryable Usage
    public class BasicIQueryableExample
    {
        public void RunExample()
        {
            // Create a list of integers.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Convert the list to an IQueryable.
            IQueryable<int> queryableNumbers = numbers.AsQueryable();

            // Use LINQ to filter the numbers greater than 2.
            var filteredNumbers = queryableNumbers.Where(n => n > 2);

            // Deferred Execution: The query is not executed until we iterate over the results.
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number); // Outputs: 3, 4, 5
            }
        }
    }

    // Example 2: Simulating IQueryable with LINQ to SQL
    public class SimulatedDatabase
    {
        // Simulate a "database" table using a list of strings.
        private List<string> users = new List<string> { "Alice", "Bob", "Charlie", "Dave", "Eve" };

        // Method to simulate querying the database using IQueryable.
        public IQueryable<string> GetUsers()
        {
            // Convert the list of users to an IQueryable.
            return users.AsQueryable();
        }
    }

    public class DatabaseQueryExample
    {
        public void RunExample()
        {
            // Create an instance of the simulated database.
            SimulatedDatabase db = new SimulatedDatabase();

            // Get an IQueryable representing the users.
            IQueryable<string> userQuery = db.GetUsers();

            // Use LINQ to filter users whose names start with "C".
            var filteredUsers = userQuery.Where(u => u.StartsWith("C"));

            // Deferred Execution: The query is not executed until the results are accessed.
            foreach (var user in filteredUsers)
            {
                Console.WriteLine(user); // Outputs: "Charlie"
            }
        }
    }

    // Main class to run the examples.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic IQueryable Example:");
            BasicIQueryableExample basicExample = new BasicIQueryableExample();
            basicExample.RunExample();

            Console.WriteLine("\nSimulated Database Query Example:");
            DatabaseQueryExample dbExample = new DatabaseQueryExample();
            dbExample.RunExample();
        }
    }

    // Summary:
    // - IQueryable vs. IEnumerable:
    //   - IQueryable is ideal for deferred execution and building queries against data sources like databases.
    //   - IEnumerable is suitable for in-memory collections where the data is already loaded.
    // - System.Linq: 
    //   - This namespace contains classes and methods for using LINQ, enabling easy querying and filtering of data using a unified query syntax.
    //   - It provides methods like Where, Select, OrderBy, etc., which allow for complex queries on collections.

    // -------------------------------------------------
    // Learn .NET API Browser: System.Linq Namespace
    // -------------------------------------------------
    // Provides classes and interfaces that support queries that use LINQ (Language Integrated Query).
    // LINQ enables querying collections, databases, XML, and more using a unified syntax.

    // Commonly Used Classes:
    // - Enumerable: Provides a set of static methods for querying objects that implement IEnumerable<T>.
    // - Queryable: Provides a set of static methods for querying data structures that implement IQueryable<T>.

    // Commonly Used Interfaces:
    // - IQueryable<T>: Represents a data source that can be queried using LINQ.
    // - IOrderedQueryable<T>: Represents the result of a sorting operation.
    // - IQueryProvider: Defines methods to create and execute queries described by an IQueryable object.

    // See also:
    // For more information, visit the .NET API browser and explore the System.Linq namespace to see how you can use LINQ to query different data sources.
}
