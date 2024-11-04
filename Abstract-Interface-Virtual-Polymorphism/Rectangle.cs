using System;
namespace Abstract_Interface_Virtual_Polymorphism
{
	public class Rectangle:Shape
	{
		public int Height;
		public int Width;

		public override void CalculateArea()
		{
			Console.WriteLine(Height * Width);
		}
	}
}

