namespace ex3a_student_grades
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            CaptureAListOfStudents();
        }

        private static void CaptureAListOfStudents()
        {
            Console.Write("Enter the number of students: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numberOfStudents))
            {
                List<Student> students = new List<Student>();

                for (int i = 1; i <= numberOfStudents; i++)
                {
                    Console.WriteLine($"\nCapturing Student {i}");
                    Student additionalStudent = CaptureStudentGrades();

                    students.Add(additionalStudent);
                }

                Console.WriteLine("\nFinal Grade Report");
                foreach (Student currentStudent in students)
                {
                    PrintStudentGrades(currentStudent);
                }
            }
            else
            {
                Console.WriteLine("Invalid number of students. Please enter a numeric value.");
            }
        }

        private static void PrintStudentGrades(Student student)
        {
            Console.WriteLine($"Student Name: {student.Name}, Average Grade = {student.AverageGrade:F2}, Letter Grade = {student.LetterGrade}");
        }

        private static Student CaptureStudentGrades()
        {
            Student student = new Student();

            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            student.Grades = new List<int>();
            string input;

            while (true)
            {
                Console.Write("Enter grade (or 'done' to finish): ");
                input = Console.ReadLine();

                if (input.Trim().ToLower() == "done") break;

                if (int.TryParse(input, out int grade))
                {
                    student.Grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a numeric value.");
                }
            }

            return student;
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Student Grades Evaluator!");
        }
    }
}