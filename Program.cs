using System;

namespace HelloWorld;

class Program {

    static void Main(String[] args) {
        Console.WriteLine("Enter a course name");
        string courseName = Console.ReadLine();
        Console.WriteLine("Welcome to "+courseName);
    }
}