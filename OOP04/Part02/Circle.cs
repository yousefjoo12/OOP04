using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Part02
{
	class Circle : ICircle
	{
		public double Radius { get; set; }

		public double Area => Math.PI * Radius * Radius;

		public void DisplayShapeInfo()
		{
			Console.WriteLine($"Circle Information \nRadius: {Radius}\nArea: {Area}");
		}
	}
}
