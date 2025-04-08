using System;
using System.Collections.Generic;
using System.Linq;

/*Source cited: ChatGPT. 04/07/2025. "Show me an example of a C# program with the following instructions*/ 
namespace StudentGradebookApp
{
    public class Student
    {
        private int studentID;
        private string studentName;
        public static List<Student> studentList = new List<Student>();

        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {studentID}, Name: {studentName}");
        }

        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create 4 students
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // Step 3: Create and populate gradebook dictionary
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            // Step 4: Check if "Tom" is in gradebook
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 0.0; // Insert Tom with GPA 0.0
                Console.WriteLine("Tom added to the gradebook with GPA 0.0.");
            }

            // Step 5: Calculate average GPA
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"\nAverage GPA: {averageGPA:F2}");

            // Step 6: Print students with GPA > average
            Console.WriteLine("\nStudents with GPA greater than average:");
            foreach (Student student in Student.studentList)
            {
                string name = student.GetName();
                if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
                {
                    student.PrintInfo();
                    Console.WriteLine($"GPA: {gradebook[name]}\n");
                }
            }
        }
    }
}

