using System.Collections.Generic;

namespace GradeBook{
    class Book{

        public Book(string name){
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public void ShowStatistics(){
             var results = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(double number in grades){

                // if (number > highGrade){
                //     highGrade = number;
                // }
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                results += number;

            }

            results /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade:N2}");
            Console.WriteLine($"The highest grade is {highGrade:N2}");
            Console.WriteLine($"The average grade is {results:N2}");
        }

        private List<double> grades;
        private string name;
    }
}

 