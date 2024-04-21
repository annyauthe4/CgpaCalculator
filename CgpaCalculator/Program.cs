using System;
namespace CgpaCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Firstname = "Oluwaseun",
                Lastname = "Otetumo"
            };
            try
            {
                student.GetCourse();
                Console.WriteLine(student.CalCgpa()); Console.ReadKey();
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
        }
    }
}
