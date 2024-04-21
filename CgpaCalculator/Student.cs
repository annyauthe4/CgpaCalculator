using System;
using System.Collections.Generic;

namespace CgpaCalculator
{
    public class Student : BaseClass
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public void GetCourse()
        {
            try
            {
                Console.WriteLine("How many course(s) do you offer?");
                int.TryParse(Console.ReadLine(), out int courses);


                for (int i = 0; i < courses; i++)
                {
                    Console.WriteLine($"Enter course {i + 1} code");
                    string courseCode = Console.ReadLine();
                    Console.WriteLine($"Enter course{i + 1} unit");
                    int courseUnit = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter course{i + 1} score");
                    int score = int.Parse(Console.ReadLine());

                    Courses.Add(new Course
                    {
                        Coursecode = courseCode,
                        CourseUnit = courseUnit,
                        Score = score
                    });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
        private decimal Grading(int score, int unit)
        {
            decimal resultScale = 0;
            if (score >= 75)
                resultScale = 4.0M;
            else if (score >= 70 && score <= 74)
                resultScale = 3.5M;
            else if (score >= 65 && score <= 69)
                resultScale = 3.25M;
            else if (score >= 60 && score <= 64)
                resultScale = 3.0M;
            else if (score >= 55 && score <= 59)
                resultScale = 2.75M;
            else if (score >= 50 && score <= 54)
                resultScale = 2.5M;
            else if (score >= 45 && score <= 49)
                resultScale = 2.25M;
            else if (score >= 40 && score <= 44)
                resultScale = 2.0M;
            else
                resultScale = 0;
            return resultScale * unit;
        }
        public decimal CalCgpa()
        {
            try
            {
                decimal sumGrading = 0;
                int sumUnit = 0;
                for (int i = 0; i < Courses.Count; i++)
                {
                    sumGrading += Grading(Courses[i].Score, Courses[i].CourseUnit);
                    sumUnit += Courses[i].CourseUnit;
                }
                return sumGrading / sumUnit;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        
    }
}
