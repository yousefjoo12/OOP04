using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interface_Ex03
{
	internal class Airplane : Vichle, IMovable, IFlyable
	{
		 void IMovable.Backward()
		{
            Console.WriteLine("Backward IMovable ");
        }

		void IFlyable.Backward()
		{
			Console.WriteLine("Backward IFlyable");
		}

		void IMovable.Forward()
		{
			Console.WriteLine("Forward IMovable");
		}

		void IFlyable.Forward()
		{
			Console.WriteLine("Forward IFlyable");
		}
	}
}
