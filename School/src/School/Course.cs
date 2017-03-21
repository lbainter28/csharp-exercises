using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private string title;
        private int courseNum;
        private int numberOfCredits;
        private List<Student> courseRoster;

        public Course(string title, int courseNum, int numberofCredits)
        {
            Title = title;
            CourseNum = courseNum;
            NumberOfCredits = numberOfCredits;
        }

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public int CourseNum
        {
            get { return courseNum; }
            private set { courseNum = value; }
        }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            private set { numberOfCredits = value; }
        }

        public Student[] CourseRoster
        {
            get
            {
                return courseRoster.ToArray();
            }
            private set
            {
                courseRoster = new List<Student>();
            }
        }

        public void AddStudent(Student name)
        {
            courseRoster.Add(name);
        }

        public override bool Equals(object obj)
        {
            Course other = (Course)obj;
            return other.CourseNum == CourseNum;
        }

        public override string ToString()
        {
            return String.Format("[{0}] {1}", CourseNum, Title);
        }
    }
}
