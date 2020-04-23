using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            //Console.Out;
            //Person firstPerson = new Person();
            //firstPerson.FirstName = "Joe";

            //Person secondPerson= new Person();
            //secondPerson = firstPerson;

            //firstPerson.FirstName = "Kennedy";
            //secondPerson.FirstName = "Grace";

            //Console.WriteLine(firstPerson.FirstName);
            //Console.WriteLine(secondPerson.FirstName);
            string sum = " " + a + b;
            String Sum = " " + a + b;


            Console.WriteLine(sum);
            Console.WriteLine(Sum);
        }
    }

    class Person
    {
        public string FirstName { get; set; }
    }
}
