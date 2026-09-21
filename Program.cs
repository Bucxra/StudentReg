using StudentReg.Models;

namespace StudentReg
{
    class Program
    {
        public static List<Students> AllStudent = new List<Students>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Student Registration");
                Console.WriteLine("1. Register New Student");
                Console.WriteLine("2. Edit Your Information");
                Console.WriteLine("3. Check Your Status");
                Console.WriteLine("4. Exit");

                Console.WriteLine("\nChoose:");
                string? opn;
                opn = Console.ReadLine();

                switch (opn)
                {
                    case "1": // registration

                        break;
                    case "2":

                        break;
                        
                    case "3":

                        break;

                    case "4":

                        break;
                }

            }
        }
    }
}
