// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace GradeBook{

    class Program{
        
        static void Main(string [] args){

            double x = 3.14;
            double y = 4.35;

            double z = x + y;

            Console.WriteLine(z);
            
            if(args.Length > 0){

                Console.WriteLine($"Hello, {args[0]} !");
            }
            else{
                Console.WriteLine("Hello");
            }
        }
    }
}                                                                                          
