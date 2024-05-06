using static System.Math;

namespace BiLabTask3
{
	public class Circle : Figure
	{
		public LineSegment Radius { get; private set; }
		public Circle(LineSegment radius) 
		{
			Radius = radius;
		}

		public override double Square()
		{
			return PI * Pow(Radius.Length, 2);
		}
	}
}
