using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentIDDict
{
    public class StudentIDDict
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudentId;
            string newStudentIdStr;

            Console.WriteLine("Enter your student's ID (or ENTER to finish):");
            do
            {
                Console.Write("ID: ");
                newStudentIdStr = Console.ReadLine();
                if (newStudentIdStr != "")
                {
                    // Get the student's name
                    Console.Write("name: ");
                    string newStudentName = Console.ReadLine();

                    newStudentId = int.Parse(newStudentIdStr);
                    students.Add(newStudentId, newStudentName);
                }
            } while (newStudentIdStr != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            StringBuilder classRoster = new StringBuilder();

            foreach (KeyValuePair<int, string> student in students)
            {
                classRoster.Append(student.Key);
                classRoster.Append(": ");
                classRoster.Append(student.Value);
                classRoster.Append("\n");
            }
            Console.WriteLine(classRoster);
            Console.ReadLine();
        }
    }
}
