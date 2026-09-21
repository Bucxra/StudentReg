using StudentReg.Models;

namespace StudentReg.Services
{
    public class StudentService
    {
        private List<Students> AllStudents = new List<Students>();

        public void RegisterStudent()
        {
            Students st = new Students();
            Console.WriteLine("Enter Your Name");
            st.Name = Console.ReadLine();
            Console.WriteLine("Enter Your Id");
            st.Id = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Gpi");
            st.Gpi = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Your Email");
            st.Email = Console.ReadLine();

            AllStudents.Add(st);
            Console.WriteLine("\nStudent Added\n");

        }
        public void EditStudent()
        {
            Console.WriteLine("Enter Your ID");
            long id = long.Parse(Console.ReadLine());

            Students student = AllStudents.FirstOrDefault(x => x.Id == id);

            if (student == null) { Console.WriteLine("Student Not Found"); return; }

            Console.WriteLine("1.Edit Name");
            Console.WriteLine("1.Edit Gpi");
            Console.WriteLine("1.Edit Email");
            Console.WriteLine("Choose:");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter your Name");
                    student.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Enter your Gpi");
                    student.Gpi = Convert.ToDecimal(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Enter your Email");
                    student.Email = Console.ReadLine();
                    break;

            }
            Console.WriteLine("Information updated!");
        }
    }
}