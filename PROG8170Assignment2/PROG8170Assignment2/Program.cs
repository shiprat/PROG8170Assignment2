using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 1, width = 1;
            try
            {
                Console.Write("Enter the length :- ");
                length = int.Parse(Console.ReadLine());
                Console.Write("Enter the breadth :- ");
                width = int.Parse(Console.ReadLine());

            }
            catch (Exception ex) {
              Console.WriteLine("Please Enter a Positive integer value" + ex.Message); }
            Rectangle rect = new Rectangle(length, width);
            bool Continue = true;
            while (Continue) {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1: SetLength");
                Console.WriteLine("2: SetBreadth");
                Console.WriteLine("3: GetLength");
                Console.WriteLine("4: GetBreadth");
                Console.WriteLine("5: GetArea");
                Console.WriteLine("6: GetPerimeter");
                Console.WriteLine("7: Exit");
                int choice = int.Parse(Console.ReadLine());

                
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter The Length Of Rectangle :- ");
                        length = Convert.ToInt32(Console.ReadLine());
                        rect.SetLength(length);
                        break;
                    case 2:
                        Console.Write("Enter The Length Of Rectangle :- ");
                        int breadth = Convert.ToInt32(Console.ReadLine());
                        rect.SetWidth(breadth);
                        break;
                    case 3:
                        Console.WriteLine("Length Of Rectangle :- " + rect.GetLength().ToString());
                        //int len = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Width Of The Rectangle :- " + rect.GetWidth().ToString());
                        //int brea = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        // Console.WriteLine("Get Area of rectangle");
                        //int length2 = Convert.ToInt32(Console.ReadLine());
                        //int breadth2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Area Of The Rectangle :- " + rect.getArea().ToString());
                        break;
                    case 6:
                        Console.WriteLine("Perimeter Of The Rectangle :- " + rect.getPerimeter());
                        /*int length1 = Convert.ToInt32(Console.ReadLine());
                        int breadth1 = Convert.ToInt32(Console.ReadLine());
                        rect.getPerimeter();*/
                        break;
                    case 7:
                        Continue = false;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}
