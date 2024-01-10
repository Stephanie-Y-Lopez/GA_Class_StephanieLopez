namespace GA_Class_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        //Guided Assigment: Class
        //01/10/24
        static void Main(string[] args)
        {
            Student Student1 = new Student { Name = "Yolis", Age = 17 };
            Student Student2 = new Student { Name = "Manjula", Age = 23 };
            //Two instances from class Student

            Professor Professor1 = new Professor { LastName = "Cram", Department = "Computer Science" };
            //instance from class Professor

            Pets Pet1 = new Pets { Type = "Dog", Breed = "Mini Poodle", Age = 4 };
            //Instance for class Pets

            Console.WriteLine("Student 1: Name - {0}, Age - {1}", Student1.Name, Student1.Age);
            Console.WriteLine("Student 1: Name - {0}, Age - {1}", Student2.Name, Student2.Age);
            //Display of instances for class Students

            Console.WriteLine("Professor 1: LastName - {0}, Department - {1}", Professor1.LastName, Professor1.Department);
            //Display of instance for class Professor

            Console.WriteLine("Pet 1: Type - {0}, Breed - {1}, Age - {2}", Pet1.Type, Pet1.Breed, Pet1.Age);
            //Display of instance for class Pets
        }
    }
}