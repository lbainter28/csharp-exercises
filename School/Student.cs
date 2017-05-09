using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; private set; } = "";
        public int StudentID { get; private set; }
        public int NumberOfCredits { get; private set; }
        public double GPA { get; private set; }

        public Student (string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentID = studentId;
            NumberOfCredits = numberOfCredits;
            GPA = gpa;
        }

        public Student(string name, int studentId)
            :this(name, studentId, 0, 0){ }
            //Name = name;
            //StudentID = studentId;
            //NumberOfCredits = 0;
            //GPA = 0.0;

        public Student(string name)
            :this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public override string ToString()
        {
            return Name + "(Credits:" + NumberOfCredits + ", GPA:" + GPA + ")";
        }

        public override bool Equals(object obj)
        {
            Student studentObj = obj as Student;
            return StudentID == studentObj.StudentID;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: numberOfCredits, gpa
        }

        public string GetGradeLevel()
        {
            //Determine the grade level of the student based on numberOfCredits
        }
    }
}
