using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter marks for the following subjects out of 100:");

                Console.Write("Maths: ");
                int maths = int.Parse(Console.ReadLine());

                Console.Write("Physics: ");
                int physics = int.Parse(Console.ReadLine());

                Console.Write("Chemistry: ");
                int chemistry = int.Parse(Console.ReadLine());

                Console.Write("Computer Science: ");
                int computerScience = int.Parse(Console.ReadLine());

                Student student = new Student(maths, physics, chemistry, computerScience);
                double average = student.CalculateAverage();
                char grade = student.DetermineGrade(average);

                student.PrintRemarks(grade);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numbers for marks.");
            }
        }
    }

    class Student
    {
        private int Maths;
        private int Physics;
        private int Chemistry;
        private int ComputerScience;

        public Student(int maths, int physics, int chemistry, int computerScience)
        {
            Maths = maths;
            Physics = physics;
            Chemistry = chemistry;
            ComputerScience = computerScience;
        }

        public double CalculateAverage()
        {
            return (Maths + Physics + Chemistry + ComputerScience) / 4.0;
        }

        public char DetermineGrade(double average)
        {
            if (average >= 80) return 'A';
            else if (average >= 70) return 'B';
            else if (average >= 60) return 'C';
            else if (average >= 50) return 'D';
            else return 'F';
        }

        public void PrintRemarks(char grade)
        {
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case 'B':
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case 'D':
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case 'F':
                    Console.WriteLine("Fail. Your grade is F");
                    break;
            }
        }
    }
}

