// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace GradeBook{

   
    class Program{
        
        static void Main(string [] args){

            var book = new Book("Jobs Grade Book :) ");
            book.AddGrade(36.69);
            book.AddGrade(72.69);
            book.AddGrade(19.69);
            book.ShowStatistics();


// sum 
            // double x = 3.14;
            // double y = 4.35;

            // var x = 3.14;
            // var y = 4.35;

            // var z = x + y;

// Array 
            // var numbers = new double[3];
            // numbers[0] = 1.23;
            // numbers[1] = 2.23;
            // numbers[2] = 6.23;

// Array init 
        //    var numbers = new [] {1.23, 2.00, 6.23}; 
           

// List init 
            // var grades = new List<double>() {1.23, 2.00, 6.23};
            // grades.Add(6.9);


        //    var results = numbers[0];
        //    results += numbers[1];
        //    results += numbers[2];

        }
    }
}                                                                                          
