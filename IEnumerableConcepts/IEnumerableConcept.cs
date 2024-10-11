using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableExample
{
    // Definition:
    // The IEnumerable interface is used to iterate over a collection of items, like a list or array.
    // It is part of the System.Collections namespace and is suitable when you want to loop through a collection.
    // It is best for situations where you only need to read data sequentially.

    // Example 1: Basic IEnumerable Usage
    public class BasicIEnumerableExample
    {
        public void RunExample()
        {
            // An example list of integers that implements IEnumerable.
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Using a foreach loop to iterate over the numbers.
            // IEnumerable allows us to loop through the collection.
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // Outputs each number: 1, 2, 3, 4, 5
            }
        }
    }

    // Example 2: Creating a Custom IEnumerable
    // Sometimes, you might want to create a custom class that implements IEnumerable for custom iteration logic.
    public class CustomIEnumerableExample
    {
        // Custom class that implements IEnumerable<int>.
        public class MyNumbers : IEnumerable<int>
        {
            // A private list of integers to iterate over.
            private List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // This method is required to implement IEnumerable.
            public IEnumerator<int> GetEnumerator()
            {
                return numbers.GetEnumerator();
            }

            // Non-generic version required for IEnumerable.
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public void RunExample()
        {
            // Create an instance of our custom class.
            MyNumbers myNumbers = new MyNumbers();

            // We can now use a foreach loop with our custom class.
            foreach (var number in myNumbers)
            {
                Console.WriteLine(number); // Outputs each number: 1, 2, 3, 4, 5
            }
        }
    }

    // Main class to run the examples.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic IEnumerable Example:");
            BasicIEnumerableExample basicExample = new BasicIEnumerableExample();
            basicExample.RunExample();

            Console.WriteLine("\nCustom IEnumerable Example:");
            CustomIEnumerableExample customExample = new CustomIEnumerableExample();
            customExample.RunExample();
        }
    }

    // Summary:
    // - IEnumerable is useful for looping through collections like arrays, lists, etc.
    // - It provides a simple way to access each element in a sequence without needing to know how the collection is structured.
    // - Custom implementations of IEnumerable allow you to control how iteration is done, which can be useful for filtering or other custom behaviors.

    // -------------------------------------------------
    // Learn .NET API Browser: System.Collections Namespace
    // -------------------------------------------------
    // Contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables, and dictionaries.
    // These collections are useful for managing groups of related objects.

    // Classes:
    // - ArrayList: Implements the IList interface using an array whose size is dynamically increased as required.
    // - BitArray: Manages a compact array of bit values, which are represented as Booleans, where true indicates that the bit is on (1) and false indicates the bit is off (0).
    // - CaseInsensitiveComparer: Compares two objects for equivalence, ignoring the case of strings.
    // - CaseInsensitiveHashCodeProvider: Supplies a hash code for an object, using a hashing algorithm that ignores the case of strings.
    // - CollectionBase: Provides the abstract base class for a strongly typed collection.
    // - Comparer: Compares two objects for equivalence, where string comparisons are case-sensitive.
    // - DictionaryBase: Provides the abstract base class for a strongly typed collection of key/value pairs.
    // - Hashtable: Represents a collection of key/value pairs that are organized based on the hash code of the key.
    // - Queue: Represents a first-in, first-out collection of objects.
    // - ReadOnlyCollectionBase: Provides the abstract base class for a strongly typed non-generic read-only collection.
    // - SortedList: Represents a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.
    // - Stack: Represents a simple last-in-first-out (LIFO) non-generic collection of objects.
    // - StructuralComparisons: Provides objects for performing a structural comparison of two collection objects.

    // Structs:
    // - DictionaryEntry: Defines a dictionary key/value pair that can be set or retrieved.

    // Interfaces:
    // - ICollection: Defines size, enumerators, and synchronization methods for all non-generic collections.
    // - IComparer: Exposes a method that compares two objects.
    // - IDictionary: Represents a non-generic collection of key/value pairs.
    // - IDictionaryEnumerator: Enumerates the elements of a non-generic dictionary.
    // - IEnumerable: Exposes an enumerator, which supports a simple iteration over a non-generic collection.
    // - IEnumerator: Supports a simple iteration over a non-generic collection.
    // - IEqualityComparer: Defines methods to support the comparison of objects for equality.
    // - IHashCodeProvider: Supplies a hash code for an object, using a custom hash function.
    // - IList: Represents a non-generic collection of objects that can be individually accessed by index.
    // - IStructuralComparable: Supports the structural comparison of collection objects.
    // - IStructuralEquatable: Defines methods to support the comparison of objects for structural equality.

    // See also:
    // For more information, visit the .NET API browser and explore the System.Collections namespace to see how you can use these collections in your projects.
}
