using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03_Collection.Q1_studentGrade
{
    internal  class StudentGrade
    {
        List<int> Grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
       
        public  void printGrade()
        {
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }

        public void sortStudentGrade() 
        {
            Grades.Sort();
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }
        public void countoflist()
        {
            Console.WriteLine(Grades.Count);

        }
        public void Capcityoflist()
        {
            Console.WriteLine(Grades.Capacity);

        }
        public void Above90()
        {
            Console.WriteLine(Grades.FindIndex(x => x > 90));
        }
        public void Below75()
        {
            var res = Grades.FindAll(x => x < 75);
            foreach (var item in res )
            {
                Console.WriteLine(item);
            }
        }
        public void Removebelow75()
        {
           var res01= Grades.RemoveAll( x => x < 75);
            foreach (var item in Grades)
            {
                Console.WriteLine(item);
            }
        }
        public void checkList()
        {
            Console.WriteLine(Grades.Contains(100));  
        }

        public void Converttostring()
        {
            var res =Grades.Select(x => $"Grade: {x}");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
