using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.ChangeAge();
            

            Console.ReadLine();
        }
    }
    class Person
    {
        public string name;
        public int age;

        public virtual void ChangeAge()
        {
            age++;
        }
    }
    class Student : Person
    {
        public int grade;
        public override void ChangeAge()
        {
            age--;
            grade++;
        }
        public void ChangeGrade()
        {
            grade += 10;
        }
    }
}
