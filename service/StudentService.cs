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
    }
}