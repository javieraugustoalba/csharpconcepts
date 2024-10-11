using System;
using System.Collections.Generic;

namespace SystemCollectionsGenericExample
{
    // Definition:
    // The System.Collections.Generic namespace provides classes and interfaces for defining generic collections.
    // It includes collections like List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T>, offering type safety.
    // Generic collections are more efficient and avoid the need for boxing and unboxing of value types.

    // Example 1: Using List<T>
    public class ListExample
    {
        public void RunExample()
        {
            // List<T> is a generic collection that stores a list of elements of a specified type.
            // Here, we create a List of integers.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Adding an element to the list.
            numbers.Add(6);

            // Iterating through the list using a foreach loop.
            foreach (var number in numbers)
            {
                Console.WriteLine(number); // Outputs: 1, 2, 3, 4, 5, 6
            }
        }
    }

    // Example 2: Using Dictionary<TKey, TValue>
    public class DictionaryExample
    {
        public void RunExample()
        {
            // Dictionary<TKey, TValue> is a generic collection that stores key-value pairs.
            // Here, we create a dictionary where keys are strings (names) and values are integers (ages).
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };

            // Adding an element to the dictionary.
            ages["Dave"] = 28;

            // Accessing a value by its key.
            Console.WriteLine("Alice's age is " + ages["Alice"]); // Outputs: Alice's age is 30

            // Iterating through the dictionary using a foreach loop.
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}"); // Outputs each name and age pair.
            }
        }
    }

    // Example 3: Using Queue<T> and Stack<T>
    public class QueueAndStackExample
    {
        public void RunExample()
        {
            // Queue<T> is a first-in, first-out (FIFO) collection.
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            // Dequeue removes and returns the element at the front of the queue.
            Console.WriteLine(queue.Dequeue()); // Outputs: First

            // Stack<T> is a last-in, first-out (LIFO) collection.
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            // Pop removes and returns the element at the top of the stack.
            Console.WriteLine(stack.Pop()); // Outputs: Third
        }
    }

    // Main class to run the examples.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List<T> Example:");
            ListExample listExample = new ListExample();
            listExample.RunExample();

            Console.WriteLine("\nDictionary<TKey, TValue> Example:");
            DictionaryExample dictionaryExample = new DictionaryExample();
            dictionaryExample.RunExample();

            Console.WriteLine("\nQueue<T> and Stack<T> Example:");
            QueueAndStackExample queueAndStackExample = new QueueAndStackExample();
            queueAndStackExample.RunExample();
        }
    }

    // Summary:
    // - System.Collections.Generic:
    //   - Provides generic collections that allow for type-safe data storage without the need for boxing/unboxing.
    //   - Includes classes like List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T>.
    //   - Generic collections are more efficient and flexible compared to their non-generic counterparts.

    // - List<T>:
    //   - Represents a dynamically resizable array.
    //   - Best for scenarios where you need to add, remove, or access elements by index.

    // - Dictionary<TKey, TValue>:
    //   - Stores key-value pairs with unique keys.
    //   - Allows fast retrieval of values based on their keys.

    // - Queue<T>:
    //   - First-in, first-out (FIFO) collection.
    //   - Use when you need to process elements in the order they were added.

    // - Stack<T>:
    //   - Last-in, first-out (LIFO) collection.
    //   - Use when you need to process the most recently added elements first.

    // -------------------------------------------------
    // Learn .NET API Browser: System.Collections.Generic Namespace
    // -------------------------------------------------
    // Provides classes and interfaces that define generic collections, which ensure type safety and avoid the overhead
    // of boxing and unboxing. These collections can store objects of a specified type without needing to cast or convert them.

    // Commonly Used Classes:
    // - List<T>: Represents a strongly typed list of objects that can be accessed by index.
    // - Dictionary<TKey, TValue>: Represents a collection of key-value pairs.
    // - Queue<T>: Represents a first-in, first-out collection of objects.
    // - Stack<T>: Represents a last-in, first-out collection of objects.
    // - HashSet<T>: Represents a collection of unique elements.

    // Commonly Used Interfaces:
    // - ICollection<T>: Defines methods to manipulate generic collections.
    // - IEnumerable<T>: Exposes an enumerator for iterating through a generic collection.
    // - IList<T>: Represents a collection that allows indexing and adding/removing items.
    // - IDictionary<TKey, TValue>: Represents a generic collection of key-value pairs.

    // See also:
    // For more information, visit the .NET API browser and explore the System.Collections.Generic namespace to see how
    // you can leverage these collections in your applications.

    // Classes

    // Comparer<T>	
    // Provides a base class for implementations of the IComparer<T> generic interface.

    // Dictionary<TKey,TValue>.KeyCollection	
    // Represents the collection of keys in a Dictionary<TKey,TValue>. This class cannot be inherited.

    // Dictionary<TKey,TValue>.ValueCollection	
    // Represents the collection of values in a Dictionary<TKey,TValue>. This class cannot be inherited.

    // Dictionary<TKey,TValue>	
    // Represents a collection of keys and values.

    // EqualityComparer<T>	
    // Provides a base class for implementations of the IEqualityComparer<T> generic interface.

    // HashSet<T>	
    // Represents a set of values.

    // KeyedByTypeCollection<TItem>	
    // Provides a collection whose items are types that serve as keys.

    // KeyNotFoundException	
    // The exception that is thrown when the key specified for accessing an element in a collection does not match any key in the collection.

    // KeyValuePair	
    // Creates instances of the KeyValuePair<TKey,TValue> struct.

    // LinkedList<T>	
    // Represents a doubly linked list.

    // LinkedListNode<T>	
    // Represents a node in a LinkedList<T>. This class cannot be inherited.

    // List<T>	
    // Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.

    // PriorityQueue<TElement,TPriority>.UnorderedItemsCollection	
    // Enumerates the contents of a PriorityQueue<TElement,TPriority>, without any ordering guarantees.

    // PriorityQueue<TElement,TPriority>	
    // Represents a collection of items that have a value and a priority. On dequeue, the item with the lowest priority value is removed.

    // Queue<T>	
    // Represents a first-in, first-out collection of objects.

    // ReferenceEqualityComparer	
    // An IEqualityComparer<T> that uses reference equality (ReferenceEquals(Object, Object)) instead of value equality (Equals(Object)) when comparing two object instances.

    // SortedDictionary<TKey,TValue>.KeyCollection	
    // Represents the collection of keys in a SortedDictionary<TKey,TValue>. This class cannot be inherited.

    // SortedDictionary<TKey,TValue>.ValueCollection	
    // Represents the collection of values in a SortedDictionary<TKey,TValue>. This class cannot be inherited.

    // SortedDictionary<TKey,TValue>	
    // Represents a collection of key/value pairs that are sorted on the key.

    // SortedList<TKey,TValue>	
    // Represents a collection of key/value pairs that are sorted by key based on the associated IComparer<T> implementation.

    // SortedSet<T>	
    // Represents a collection of objects that is maintained in sorted order.

    // Stack<T>	
    // Represents a variable size last-in-first-out (LIFO) collection of instances of the same specified type.

    // SynchronizedCollection<T>	
    // Provides a thread-safe collection that contains objects of a type specified by the generic parameter as elements.

    // Structs
    // Dictionary<TKey,TValue>.Enumerator	
    // Enumerates the elements of a Dictionary<TKey,TValue>.

    // Dictionary<TKey,TValue>.KeyCollection.Enumerator	
    // Enumerates the elements of a Dictionary<TKey,TValue>.KeyCollection.

    // Dictionary<TKey,TValue>.ValueCollection.Enumerator	
    // Enumerates the elements of a Dictionary<TKey,TValue>.ValueCollection.

    // HashSet<T>.Enumerator	
    // Enumerates the elements of a HashSet<T> object.

    // KeyValuePair<TKey,TValue>	
    // Defines a key/value pair that can be set or retrieved.

    // LinkedList<T>.Enumerator	
    // Enumerates the elements of a LinkedList<T>.

    // List<T>.Enumerator	
    // Enumerates the elements of a List<T>.

    // PriorityQueue<TElement,TPriority>.UnorderedItemsCollection.Enumerator	
    // Enumerates the element and priority pairs of a PriorityQueue<TElement,TPriority>, without any ordering guarantees.

    // Queue<T>.Enumerator	
    // Enumerates the elements of a Queue<T>.

    // SortedDictionary<TKey,TValue>.Enumerator	
    // Enumerates the elements of a SortedDictionary<TKey,TValue>.

    // SortedDictionary<TKey,TValue>.KeyCollection.Enumerator	
    // Enumerates the elements of a SortedDictionary<TKey,TValue>.KeyCollection.

    // SortedDictionary<TKey,TValue>.ValueCollection.Enumerator	
    // Enumerates the elements of a SortedDictionary<TKey,TValue>.ValueCollection.

    // SortedSet<T>.Enumerator	
    // Enumerates the elements of a SortedSet<T> object.

    // Stack<T>.Enumerator	
    // Enumerates the elements of a Stack<T>.

    // Interfaces
    // IAsyncEnumerable<T>	
    // Exposes an enumerator that provides asynchronous iteration over values of a specified type.

    // IAsyncEnumerator<T>	
    // Supports a simple asynchronous iteration over a generic collection.

    // ICollection<T>	
    // Defines methods to manipulate generic collections.

    // IComparer<T>	
    // Defines a method that a type implements to compare two objects.

    // IDictionary<TKey,TValue>	
    // Represents a generic collection of key/value pairs.

    // IEnumerable<T>	
    // Exposes the enumerator, which supports a simple iteration over a collection of a specified type.

    // IEnumerator<T>	
    // Supports a simple iteration over a generic collection.

    // IEqualityComparer<T>	
    // Defines methods to support the comparison of objects for equality.

    // IList<T>	
    // Represents a collection of objects that can be individually accessed by index.

    // IReadOnlyCollection<T>	
    // Represents a strongly-typed, read-only collection of elements.

    // IReadOnlyDictionary<TKey,TValue>	
    // Represents a generic read-only collection of key/value pairs.

    // IReadOnlyList<T>	
    // Represents a read-only collection of elements that can be accessed by index.

    // IReadOnlySet<T>	
    // Provides a readonly abstraction of a set.

    // ISet<T>	
    // Provides the base interface for the abstraction of sets.
}
