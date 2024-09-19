using System;
using System.Numerics;
using System.Text.Json;
using System.Threading.Channels;
using System.Xml.Linq;

namespace CsharpBasics1
{


}

// ------------- if else
/*  class Program
  {
      static void Main(string[] args)
      {   

          Console.WriteLine("What's your Name?");
          String name = Console.ReadLine();

          if (name == "")
          {
              Console.WriteLine("Please Enter Your Name");
          }
          else
          {
              Console.WriteLine("The Name is : " + name);
          }
      }

  }

                     // Switch----------------------- CASE
  class Program
  {
      static void Main(string[] args)
      {
          Console.WriteLine("What's the Day");
          String day = Console.ReadLine();

          switch (day)
          {
              case "Monday":

                      Console.WriteLine("It's a Monday");
                  break;
              case "Tuesday":

                      Console.WriteLine("It's a Tuesday");
                  break ;
              case "Wednesday":

                      Console.WriteLine("It's a Wednesday");
                  break;
              case "Thursday":

                      Console.WriteLine("It's a Thursday");
                  break;
              case "Friday":

                      Console.WriteLine("It's a Friday");
                  break;
              case "Saturday":

                      Console.WriteLine("It's a Saturday");
                  break;
              case "Sunday":

                      Console.WriteLine("It's a Sunday");
                  break;
                  default :
                  Console.WriteLine(day + " it's not a day");
                      break;
          }
      }
  } 
                
                      // while------------------------------------- loop
  class Program
    {
        static void Main(string[] args)
        {

            string name = "";
                                                        //code will be repeat untill it reminds true
            while (name == "")
            {
                Console.WriteLine("Enter Your Name");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name);
        }

    }



                //  --------- FOR LOOP____________

   class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("HAPPY NEW YEAR");
        }
        }



                          //---------------nested loop---------------------           


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of Rows : ");
            int row =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("No. of Column : ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("No. of Symbol : ");
            string symbol = Console.ReadLine();


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();

            }
            
        }
    }

               //-----------------------Array-----------

    class Program
    {
        static void Main(string[] args) 
        {

            String[] cars = new string[3];

            cars[0] = "BMW";
            cars[1] = "Volvo";
            cars[2] = "Skoda";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[]);
            }


        }

    }
    
                 //----------foreach loop----------------

 class Program
    {
        static void Main(string[] args)
        {

            String[] cars = { "BMW", "Volvo", "skoda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }


        }


                       
                   //-------------Methods-----------
                           


   class Program
    {
        static void Main(string[] args)
        {

            string name = "Gokul";
            int years = 22;

            HappyBrday( name,  years);
        }

        public static void HappyBrday(string name, int years)
        {
            Console.WriteLine("HBD to you! ");
            Console.WriteLine("HBD to you! ");
            Console.WriteLine("HBD to you dear " + name);
            Console.WriteLine("You are " + years + " years old now!");
            Console.WriteLine("HBD to you! ");
        }
    }

             // ---------------return ---------------

    class Program
    {
        static void Main(string[] args)
        {

            double result;

            Console.WriteLine("Enter the X value : ");
            double x=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Y value : ");
            double y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }


    }



            //--------------------method overriding----------------

    class Program
    {
        static void Main(string[] args)
        {

            double a = 2;
            double b = 3;
            double c = 4;
            double total = a*b*c;
            Console.WriteLine(total);

        }
       
        static double Multiply(double a, double b)
        {
            return a * b ;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }




                         //---------------------params keyword----------------
    class Program
    {
        static void Main(string[] args)
        {
            double total = Check(23.4 + 58 + 45.9);
            Console.WriteLine(total);
        }

        static double Check( params double[] prices)
        {
            double total = 0;

            foreach (double Price in prices)
            {
                total += Price;
            }
            return total;

        }
        
    }



                  //---------------------Classes--------------

    class Program
    {
        static void Main(string[] args)
        {
            Message.Alert();
            Message.Thanks();
            Message.welcome();

        }
    }

    static class Message
    {
        public static void Alert()
        {
            Console.WriteLine("Be Safe Drive Carefully");
        }
        public static void Thanks()
        {
            Console.WriteLine("You Successfully Crossed the Dangerzone ");
        }
        public static void welcome()
        {
            Console.WriteLine("Come Back Soon");
        }



    }



                     //-------------------objects-------------------



   class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }


                  //-----------------Constructor------------


 class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }


          //------------------Constructor overloading


 class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey();
        }   
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread)
        {
            this.bread = bread;
        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }

   //--------------------Inheritance-------------------



 class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();

            Console.ReadKey();
        }   
    }
    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }


        //----------------------abstract classes---------------------


class Program
    {
        static void Main(string[] args)
        {
            // abstract classes =  modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //can't create a vehicle object

            Console.ReadKey();
        }   
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }






    // --------------------- ENUM ---------------------

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Earth position is " + (int)Planet.Earth);

            string name = Planet.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("planet: " + name);
            Console.WriteLine("radius: " + radius + "km");
            Console.WriteLine("volume: " + volume + "km^3");
        }
         static double Volume(PlanetRadius radius )
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
        enum Planet
        {
            Mercury = 1,
            Venus = 2,
            Earth = 3,
            Mars = 4,
            Jupiter = 5,
            Saturn = 6,
            Uranus = 7,
            Neptune = 8,
            Pluto = 9
        }
        enum PlanetRadius
        {
            Mercury = 2439,
            Venus = 6051,
            Earth = 6371,
            Mars = 3389,
            Jupiter = 69911,
            Saturn = 58232,
            Uranus = 25362,
            Neptune = 24622,
            Pluto = 1188
        }
    }


                 // ---------------- GENERICS ____________

    class program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 1, 2, 3, 4 };
            double[] doubleArray = { 21.3, 56.8, 32.9 };
            string[] stringArray = { "Vasa", "Gokul" };

            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);


        }
        public static void DisplayElements<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }

    }





// get set  -------------------- properties
/*
class Program
{
  static void Main(string[] args)
  {
      Car car = new Car(400);

      car.Speed = 1000;

      Console.WriteLine(car.Speed);
  }
}
class Car
{
  public int speed;

  public Car(int speed)
  {
      this.speed = speed;
  }

  public int Speed
  {
      get { return speed; }
      set
      {
          if (value > 500)
          {
              speed = 500;
          }
          else
          {
              this.speed = value;

          }
      }

  }


}
*/