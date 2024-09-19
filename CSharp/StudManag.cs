using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class StudManag
    {
        private List<Student> _students = new List<Student>();

        public void AddStud(Student students)
        {
            _students.Add(students);
        }
        public Student GetStudByID(int id)
        {
            return _students.Find(x => x.Id == id);
        }
    }
}
