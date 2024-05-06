namespace BiLabTask3
{
	internal class Program
	{
		static void Main()
		{
			Figure[] figures = new Figure[]
			{
			new Circle(new LineSegment(5)),
			new Rectangle(new LineSegment(3), new LineSegment(4)),
			new Triangle(new LineSegment(3), new LineSegment(4), new LineSegment(5))
			};

			foreach (Figure figure in figures)
			{
				string type = figure.GetType().Name;
				double square = figure.Square();
				Console.WriteLine($"{type} - S:{square}");
			}
		}
	}
}
