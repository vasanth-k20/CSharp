using System;
using System.Numerics;
using System.Text.Json;
using System.Threading.Channels;
using System.Xml.Linq;
using System;
using CSharp;

class Program 
{
    static void Main(string[] args)
    {

        bool cont = true;

        StudManag sManag = new StudManag();

        sManag.AddStud( new Student("Vasanth",23,2401,"CSE"));
        sManag.AddStud(new Student("Gokul", 22, 2402, "ANM"));
        sManag.AddStud(new Student("Jeevan", 20, 2404, "CYBER"));
        sManag.AddStud(new Student("Gandhi", 24, 2403, "IT"));

        while (cont)
        {
           
            Console.WriteLine("Enter STUDENT_ID to get Student Data ");

            try
            {
                int id = Convert.ToInt32(Console.ReadLine());

                Student students = sManag.GetStudByID(id);
                if (id != 0)
                {
                    Console.WriteLine(students.GetStudInfo());
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid ID");
            }

            while (true) {
                Console.WriteLine("If You Want to Continue Enter {True} or else Enter {False}");
                try
                {

                    cont = Convert.ToBoolean(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Data");
                }
            }
          
        }
      
    }
}