using StudentReg.Models;

namespace StudentReg.Services
{
    public class StudentService
    {
        private List<Students> AllStudents = new List<Students>();
        //===========================REGISTRATION===========================
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
        //===========================EDIT INFO===========================
        public void EditStudent()
        {
            Console.WriteLine("Enter Your ID");
            long id = long.Parse(Console.ReadLine());

            Students student = AllStudents.FirstOrDefault(x => x.Id == id);

            if (student == null) { Console.WriteLine("Student Not Found"); return; }

            Console.WriteLine("1.Edit Name");
            Console.WriteLine("1.Edit Gpi");
            Console.WriteLine("1.Edit Email");
            Console.WriteLine("Choose:\n");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("\nEnter your Name");
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

            Console.WriteLine("\nInformation updated!");
            }
        //===========================CHECK INFO===========================
        public void CheckInfo()
        {
            Console.Write("Enter Your ID");
            long id = long.Parse(Console.ReadLine());
            Students student = AllStudents.FirstOrDefault(x =>x.Id == id);
            if (student == null) { Console.WriteLine("Student Not Found"); return; }

            Console.WriteLine($"\nName: {student.Name}");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"GPI: {student.Gpi}");
            Console.WriteLine($"Email: {student.Email}\n");

            if (student.Gpi > 3)
            { 
                Console.WriteLine("Status: Passed\n");
            }
            else { Console.WriteLine("Status: Failed\n"); }
        }
    } 
}