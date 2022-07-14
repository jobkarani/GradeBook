// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace GradeBook{

    class Program{
        
        static void Main(string [] args){


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
           var numbers = new [] {1.23, 2.00, 6.23}; 

        //    var results = numbers[0];
        //    results += numbers[1];
        //    results += numbers[2];

            var results = 0.0;
            
            foreach(double number in numbers){

                results += number;

            }

            Console.WriteLine(results);
            
            if(args.Length > 0){

                Console.WriteLine($"Hello, {args[0]} !");
            }
            else{
                Console.WriteLine("Hello");
            }
        }
    }
}                                                                                          
