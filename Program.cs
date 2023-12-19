using System;

namespace BTKAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            // struct - Usage
            //Student std = new Student();
            //std.Number = 10;
            //std.Name = "Asli";
            //std.Surname = "Atilgan";
            //std.Gender = true;

            // Alternative Usage
            //var std2 = new Student()
            //{
                
            //    Number = 20,
            //    Name = "Kerem",
            //    Surname = "Yildirim",
            //    Gender = false,

            //};

            //// Alternative Usage 2



            /// if we use on the Student.cs side we dont have to use these codes anymore
            //Console.WriteLine($"{std.Number} " +
            //    $"{std.Name} {std.Surname} " +
            //    $"{std.Gender}");

            //Console.WriteLine($"{std2.Number} " +
            //   $"{std2.Name} {std2.Surname} " +
            //   $"{std2.Gender}");

            //Console.WriteLine($"{std3.Number} " +
            //   $"{std3.Name} {std3.Surname} " +
            //   $"{std3.Gender}");

            //Console.WriteLine($"{std4.Number} " +
            //   $"{std4.Name} {std4.Surname} " +
            //   $"{std4.Gender}");

            // We are able to make them out too if we use var std list
            //Console.WriteLine(std);
            //Console.WriteLine(std2);
            //Console.WriteLine(std3);
            //Console.WriteLine(std4);

            var studentList = new List<Student>()
            {
                new Student(10, "Asli", "Atilgan", true),
                new Student(20, "Kerem", "Yildirim", false),
                new Student(40, "Hakan", "Karlıdağ"),
            new Student(30, "Ekin", "Kara", true)
        };

            foreach (Student o in studentList) 
                {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }
}