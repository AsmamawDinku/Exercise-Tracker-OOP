// This class demonstrates the functionality of the Exercise Tracking Program.
// It creates instances of Running, Cycling, and Swimming, and displays summaries and statistics for each activity.
// The program uses polymorphism to handle different types of activities uniformly.
// It also includes a main method to run the program and display the results.
// This is a simple exercise tracking program that demonstrates the use of inheritance and polymorphism in C#.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("04 Nov 2022", 45, 15.0),
            new Swimming("05 Nov 2022", 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
