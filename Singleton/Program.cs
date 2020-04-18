using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );

            PrintTeacherDetails();
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            LazySingleton fromTeacher = LazySingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            LazySingleton fromStudent = LazySingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }




    }
}
