using System;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks.Employee person1 = new Tasks.Employee("Jon", 1000);
            Tasks.Employee person2 = new Tasks.Employee("Jek", 1500);

            Console.WriteLine($"Salary of the {person1._name} : {person1._salary};");
            Console.WriteLine($"Salary of the {person2._name} : {person2._salary};");
            Console.WriteLine();
            person1++;
            person2--;
            Console.WriteLine($"New salary of the {person1._name} : {person1._salary};");
            Console.WriteLine($"New salary of the {person2._name} : {person2._salary};");

            Console.WriteLine($"Salaryes of the person1 == person2 : {person1 == person2} ");
            Console.WriteLine($"Salaryes of the person1 != person2 : {person1 != person2} ");

            Console.WriteLine($"Salaryes of the person1 > person2 : {person1 > person2} ");
            Console.WriteLine($"Salaryes of the person1 < person2 : {person1 < person2} ");

            Console.WriteLine();
            Task2.Matrix matrix1 = new Task2.Matrix (4, 4);

            Console.WriteLine($"Matrix matrix 1:");

            Task2.Matrix.ShowMatrix(matrix1 );

            Console.WriteLine();

            Task2.Matrix matrix2 = new Task2.Matrix(4, 4);

            Console.WriteLine($"Matrix matrix 2:");

            Task2.Matrix.ShowMatrix(matrix2);

            Console.WriteLine();

            Task2.Matrix result =matrix1 + matrix2;

            Console.WriteLine($"Matrix 1 + matrix 2 :");

            Task2.Matrix.ShowMatrix(result);

            Console.WriteLine();

            Task2.Matrix result1 =matrix2 - matrix1;

            Console.WriteLine($"Matrix 1 - matrix 2 :");

            Task2.Matrix.ShowMatrix(result1);

            Console.WriteLine();

            Task2.Matrix result3 = matrix2 + 100;

            Console.WriteLine($"Matrix 1 + 100 :");

            Task2.Matrix.ShowMatrix(result3);

            Console.WriteLine();

            Console.Write("matrix1!=matrix2:");
            Console.Write(matrix1 != matrix2);




            Console.ReadLine();
        }
    }
}
