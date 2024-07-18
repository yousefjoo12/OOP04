using OOP04.IClonable;
using OOP04.Interface_Ex02;
using OOP04.Interface_Ex03;
using OOP04.Part02;
using System;

namespace OOP04
{
	internal class Program
	{
		public static void Print10NumFromSeries(ISeries serise)
		{
			if (serise == null)
				return;
			for (int i = 0; i < 10; i++)
			{
				Console.Write($"{serise.Current}\t");
				serise.GetNext();
			}
			serise.Reset();
			Console.WriteLine();
		}
		static void Main(string[] args)
		{

			#region Interface-Ex02
			//SeriseByTow serise = new SeriseByTow();
			//SeriseByThree serise1 = new SeriseByThree();

			//Print10NumFromSeries(serise);
			//Print10NumFromSeries(serise1);

			#endregion

			#region Interface-Ex03

			//IMovable movable = new Airplane();
			//IFlyable flyable = new Airplane();
			//movable.Forward();
			//flyable.Forward();



			#endregion

			#region Shallow Copy Vs Deep Copy
			//int[] Arr01 = { 1, 2, 3 };
			//int[] Arr02 = { 4, 5, 6 };
			//Console.WriteLine($"HashCode Arr01={Arr01.GetHashCode()}");
			//Console.WriteLine($"HashCode Arr02={Arr02.GetHashCode()}");
			#region Shallow Copy

			////Shallow Copy
			//Arr02 = Arr01;
			//         //this obj { 1, 2, 3 } has 2 ref
			//         //this obj { 4, 5, 6 } unreachable obj
			//         Console.WriteLine("After Shallow Copy");
			//Console.WriteLine($"HashCode Arr01={Arr01.GetHashCode}");
			//Console.WriteLine($"HashCode Arr02={Arr02.GetHashCode}");
			////الاتنين بيشاورو علي نفس الحاجه في الهيب
			////والاتنين بيحملو نفس العنوان 
			//Arr02[0] = 100;
			//Console.WriteLine(Arr01[0]);
			#endregion

			#region Deep Copy
			//Arr02 = (int[]) Arr01.Clone();
			////بتعملي نسخه جديد من الابجيكت وتاخد نفس الداتا الي موجوده في الاول بتحته في التاني
			//Console.WriteLine("After Deep Copy");
			//Console.WriteLine($"HashCode Arr01={Arr01.GetHashCode()}");
			//Console.WriteLine($"HashCode Arr02={Arr02.GetHashCode()}");
			//Arr02[0] = 100;
			//Console.WriteLine(Arr01[0]);
			#endregion
			#endregion
			//string[] Name01 = new string[] { "joker" };
			//string[] Name02 = new string[1]; 
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");
			#region shallow copy

			//Name02 = Name01; 
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");

			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);

			//Console.WriteLine("after change");
			//Name02[0] = "joo";
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			//Name01[0] = "yousef";
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			#endregion
			#region Deep copy
			//Name02 = (string[])Name01.Clone();
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			//Console.WriteLine("after change");
			//Name02[0] = "joo";
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]); 
			#endregion
			//StringBuilder[] Name01 = new StringBuilder[1];
			////Name01[0].Append("yousef"); 
			//Name01[0] = new StringBuilder("yousef");
			//StringBuilder[] Name02 = new StringBuilder[1];
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			#region shallow copy
			//Name02 = Name01;
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			//Console.WriteLine("after change");
			//Name02[0].Append(" ayman"); 
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			#endregion
			#region Deep copy
			//Name02 = (StringBuilder[])Name01.Clone();
			//Console.WriteLine($"HAshCode Name01 :{Name01.GetHashCode()}");
			//Console.WriteLine($"HAshCode Name02 :{Name02.GetHashCode()}");
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			//Console.WriteLine("after change");
			//Name02[0].Append(" ayman");
			//Console.WriteLine(Name01[0]);
			//Console.WriteLine(Name02[0]);
			#endregion
			#region ICloneable
			//Employee employee1 = new Employee()
			//{
			//	Id = 1,
			//	Name = "joo",
			//	Salary=3500,
			//	Department = new Department()
			//	{
			//		Id= 10,
			//		Name= "Dep01"
			//	}
			//};
			//Employee employee2 = new Employee()
			//{
			//	Id = 5,
			//	Name = "yousef",
			//	Salary = 5050
			//};
			//Console.WriteLine($"HAshCode employee1 :{employee1.GetHashCode()}");
			//Console.WriteLine($"HAshCode employee2 :{employee2.GetHashCode()}");

			//Employee employee3 = new Employee(employee1);

			//Console.WriteLine("After Deep Copy");

			////Employee employee3 = (Employee)employee1.Clone();

			//Console.WriteLine($"HAshCode employee1 :{employee1.GetHashCode()}");
			//Console.WriteLine($"HAshCode employee3 :{employee3.GetHashCode()}");

			//Console.WriteLine(employee1.ToString());
			//Console.WriteLine(employee3.ToString());
			//Console.WriteLine("After change");

			//employee3.Department.Name = "HR";

			//Console.WriteLine(employee1.ToString());
			//Console.WriteLine(employee3.ToString());
			#endregion

			#region IComparable
			//int[] numbers = { 7, 9, 6, 2, 8, 4, 5, 15, 102 };

			//Array.Sort(numbers);

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}

			//Employee[] employees =
			//{
			//	new Employee(){Id = 1,Name = "youaef",Salary = 2531,},
			//		new Employee(){Id = 5,Name = "ahmed",Salary = 3000,},
			//			new Employee(){Id = 7,Name = "mohmed",Salary = 4000,}

			//};
			//Array.Sort(employees);

			//foreach (var item in employees)
			//{
			//	Console.WriteLine(item);
			//}

			//for (int i = 0; i < employees.Length; i++)
			//{
			//	for (int j = 0; j < employees.Length-j-1; j++)
			//	{
			//		if (employees[j].compareTo(employees[j + 1]) == 1)
			//		{
			//			swap(employees[j], employees[j + 1])

			//		}
			//	}
			//}
			#endregion
			#region Part 02
			//Question 1
			//What is the primary purpose of an interface in C#?
			//b
			//Question 2
			//a
			//Question 3
			//b
			//Question 4
			//b
			//Question 5
			//d
			//Question 6
			//a
			//Question 7
			//b
			//Question 8
			//b
			//Question 9
			//b
			//Question 10
			//c

			#endregion
			#region assignment
			ICircle circle = new Circle();
			circle.Radius = 4;
			circle.DisplayShapeInfo();

			IRectangle rectangle = new Rectangle();
			rectangle.Length = 4;
			rectangle.Width = 7;
			rectangle.DisplayShapeInfo();
			#endregion
		}
	}
}