using System;

namespace Person1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string childName = Console.ReadLine();
            int childAge = int.Parse(Console.ReadLine());
            string motherName = Console.ReadLine();
            int motherAge = int.Parse(Console.ReadLine());
            string fatherName = Console.ReadLine();
            int fatherAge = int.Parse(Console.ReadLine());

            Child child = new Child(childName, childAge, new Person(motherName, motherAge), new Person(fatherName, fatherAge));
            Console.WriteLine(child);
        }
    }
}