using System;
namespace Abstract_Interface_Virtual_Polymorphism
{
	public class Circle:Shape
	{
		public int Radius;

		public override void CalculateArea()
		{
			Console.WriteLine(Radius * Radius * Math.PI);
		}
	}
}

