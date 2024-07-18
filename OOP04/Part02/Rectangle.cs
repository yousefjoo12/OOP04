using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Part02
{
	class Rectangle : IRectangle
	{
		public double Length { get; set; }
		public double Width { get; set; } 
		public double Area => Length * Width;

		public void DisplayShapeInfo()
		{
            Console.WriteLine($"Rectangle Information \nLength: {Length}\nWidth: {Width}\nArea: {Area}"); 
		}
		
	}
}
