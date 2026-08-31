using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

// Generics Collections
class Program
{
    static void Main(string[] args)
    {
        //Generic Collections Lists and Dictionary and Hashset and Queue and Stack and Linked List
        // List<int> ints = [1, 2, 3, 4, 5, 6];
        // ints.Add(12);

        // ints.ForEach((int n) =>
        // {
        //     Console.WriteLine(n);
        // });

        // ints.ForEach(Console.Write);

        // ints.Find((int n) => n == 2);
        // ints.Contains(12);
        // ints.AddRange([7, 8, 9, 10, 11]);


        // foreach (var each in ints)
        // {
        //     Console.WriteLine(each);
        // }
        // Console.WriteLine(ints.Capacity);

        //     Dictionary<string, List<int>> grades = new()
        //     {
        //         {"me", [1,1,1]},
        //         {"you", [2,2,2]},


        // };

        // grades["him"] = [3, 3, 3];

        // if (grades.TryGetValue("me", out List<int>? myGrades))
        // {
        //     foreach (var grade in myGrades)
        //     {
        //         Console.WriteLine(grade);
        //     }

        // }
        // if (grades.TryGetValue("him", out List<int>? myGrades))
        // {
        //     foreach (var grade in myGrades)
        //     {
        //         Console.WriteLine(grade);
        //     }

        // }

        // Hashset except unique values but it not throught error it override the same key with previous

        // HashSet<string> names = ["me", "me", "you"];

        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }

        // QUEUE

        // Queue<string> queue = [];
        // queue.Enqueue("");
        // queue.Dequeue();


        // Stack<int> stack = [];
        // stack.Push(13);
        // stack.Pop();


        LinkedList<int> ints = [];
        ints.AddFirst(2);
        ints.AddLast(3);

        foreach (var i in ints)
        {
            Console.WriteLine(i);

        }


    }
}
