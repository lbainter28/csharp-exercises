using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private static int nextStudentId = 1;
        private string name = "";
        private int studentId = 0;
        //private int numberOfCredits;
        //private double totalQualityScore;
        //private double gpa;
        private string gradeLevel = "freshman";

        private readonly GradeList grades = new GradeList();

        private static readonly string[] gradeLevels = new string[] { "freshman", "sophomore", "junior", "senior" };

        //public Student(string name, int studentId, int numberOfCredits, double gpa)
        //{
        //    Name = name;
        //    StudentId = studentId;
        //    NumberOfCredits = numberOfCredits;
        //    Gpa = gpa;
        //}

        //public Student(string name, int studentId)
        //    : this(name, studentId, 0, 0) { }

        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
        }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            private set { studentId = value; }
        }

        //private int NumberOfCredits
        //{
        //    get { return numberOfCredits; }
        //    set { numberOfCredits = value; }
        //}

        //private double Gpa
        //{
        //    get { return gpa; }
        //    set { gpa = value; }
        //}

        //private double TotalQualityScore
        //{
        //    get { return Gpa * NumberOfCredits; }
        //    set { totalQualityScore = value; }
        //}

        public int NumberOfCredits
        {
            get { return grades.Credits; }
        }

        public double Gpa
        {
            get { return grades.Gpa; }
        }

        public string GradeLevel
        {
            get { return gradeLevel; }
            private set
            {
                if (!gradeLevels.Contains(value))
                {
                    return;
                }
                gradeLevel = value;
            }
        }

        public void AddGrade(int courseCredits, double grade)
        {
            //TotalQualityScore = TotalQualityScore + (grade * courseCredits);
            //NumberOfCredits = NumberOfCredits + courseCredits;
            //Gpa = TotalQualityScore / NumberOfCredits;

            Grade newGrade = new School.Grade(courseCredits, grade);
            grades.Add(newGrade);
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits < 30)
            {
                return GradeLevel;
            }
            else if (NumberOfCredits < 60)
            {
                return GradeLevel = "Sophomore";
            }
            else if (NumberOfCredits < 90)
            {
                return GradeLevel = "Junior";
            }
            else
            {
                return GradeLevel = "Senior";
            }
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            return other.StudentId == StudentId;
        }

        public override string ToString()
        {
            return String.Format("[{0}] {1}", StudentId, Name);
        }

        //public string Name { get; set; }
        //public int StudentID { get; set; }
        //public int numberOfCredits { get; set; } = 0;
        //public double Gpa { get; set; } = 0;
    }
}
