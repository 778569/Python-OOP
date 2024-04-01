using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Test_APP
{
    public class RectangleR
    {

        public int width = 0;
        public int height = 0;
        public int area = 0;
        public int perimeter = 0;

        public int count = 0;

       
        public RectangleR(int Width = 0, int Height = 0)
        {
            this.width = Width;
            this.height = Height;
            //this.area = Area;
            //this.perimeter = Parameter;
        }

        public int FindArea()
        {
            area = width * height;
            return area;
        }

        public int finePerimeter()
        {
            var oneSidelength = height + width;
            perimeter = 2 * oneSidelength;
            return perimeter;
        }

        public void printDetails()
        {
            Console.WriteLine("width : " + width );
            Console.WriteLine("height : " + height);

            Console.WriteLine("area : " + area);

            Console.WriteLine("parimeter : " + perimeter);

            Console.WriteLine("count : " + count);

        }

    }
}
