using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        public string _StudentId { get; set; }
        public string _email { get; set; }

        public Student (string Nama, int Age, string Idstudent, string Email) : base(Nama, Age)
        {
            _nama = Nama;
            _umur = Age;
            _StudentId = Idstudent;
            _email = Email;
        }

        public void getDetailStudent() //jika ingin menampilkan detail students
        {
            Console.WriteLine("Id mahasiswa : " + _StudentId);
            Console.WriteLine("Email : " + _email);
        }
    }
}
