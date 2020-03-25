using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    class Program
    {

        public class Student
        {
            public string name;
            public string initials;
            public int term;

            public Student()
            {
            }
            public Student(string name, string initials)
            {
                this.name = name;
                this.initials = initials;
            }


            public Student(int term)
            {
                this.term = term;
            }

            public void getMarks()
            {

                int n = 5;
                int[] marks = new int[n];
                int sum = 0;

                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    marks[i] = random.Next(2, 6);
                    sum = sum += marks[i];
                }
                Console.WriteLine("Успеваемость: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(marks[i] + " ");
                }
                Console.WriteLine("Среднее арифметическое: ");
                Console.Write(sum / n);
            }

            public void getInfo()
            {
                Console.WriteLine($"Фамилия: {name}, Инициалы: {initials}, Группа: {term}");
            }


        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Чацкий";
            student.initials = "Ч.С.И.";
            student.term = 2;
            student.getInfo();
            student.getMarks();

            Console.ReadLine();
        }
    }
}
