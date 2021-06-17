using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Assignment2
{
    class Rectangle
    {
        int length, width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.width = breadth;
        }
        public int GetLength()
        {
            return length;
            //int leng = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The length is" + length);
        }
        
        public int SetLength( int Length)
        {
           
            if (Length < 0)
                return (Length = 1);
            else
                    this.length = Length;

            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
            //int leng = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The length is" + length);
        }

        public int SetWidth(int width)
        {

            if (width < 0)
                return (width = 1);
            else
                this.width = width;

            return this.width;
        }

        public int getPerimeter() {

            return 2 * (this.width + this.length);
        }

        public int getArea() {
            return this.length * this.width;
        }
       
    }}

