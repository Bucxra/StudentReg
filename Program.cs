using StudentReg.Models;
using StudentReg.Services;

namespace StudentReg
{
    class Program
    {
        public static List<Students> AllStudent = new List<Students>();
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();

            while (true)
            {
                Console.WriteLine("Student Registration");
                Console.WriteLine("1. Register New Student");
                Console.WriteLine("2. Edit Your Information");
                Console.WriteLine("3. Check Your Status");
                Console.WriteLine("4. Exit");

                Console.WriteLine("\nChoose:");
                string? opn = Console.ReadLine();

                switch (opn)
                {
                    case "1": // registration
                        studentService.RegisterStudent();
                        break;
                    case "2": // Edit info

                        break;
                        
                    case "3": // Check info

                        break;

                    case "4": // Exit
                    Environment.Exit(1);
                        break;
                }

            }
        }
    }
}
