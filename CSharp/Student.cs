using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    public class Student
    {
        private string _name ;
        private int _age ;
        private int _id;
        private string _dept;

        public Student(string name, int age, int id, string dept)
        {
            _name = name;
            _age = age;
            _id = id;
            _dept = dept;

        }

        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value;}
        }

        public string Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        public string GetStudInfo()
        {
            return $"Name: {_name}, Age: {_age}, Student ID: {_id}, Department: {_dept}";
        }

    }
       
}
