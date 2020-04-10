using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.getNameandAge();

            Teacher teacher = new Teacher("Thomas", 35, "19302", "Math");
            teacher.getNameandAge();

            Student student = new Student("Hafiidh", 19, "2645", "pradana@gmail.com");
            student.getNameandAge();

            Console.ReadKey();
        }
    }
}
