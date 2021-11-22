using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance
            Student student1 = new Student();
            //instance 1 values
            student1.student_name = "Joe Soap";
            student1.student_id = "1234";
            student1.student_course = "Certificate in Networking";

            //instance 2 values
            Student student2 = new Student();
            student2.student_name = "Jane Doe";
            student2.student_id = "999";
            student2.student_course = "Engineering N3";

            //call the function for printing the message
            student1.Message();
            student2.Message();

        }
        //class
        public class Student
        {
            //attributes
            public string student_id;
            public string student_name;
            public string student_course;

            //function
            public void Message()
            {
                Console.WriteLine("Student " + student_name +
                " (" + student_id + ") is enrolled for " + student_course + ".");
                Console.ReadLine();
            }
        }
    }
}
