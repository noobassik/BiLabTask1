namespace BiLabTask3
{
	public class Rectangle : Figure
	{
		public LineSegment Width { get; private set; }
		public LineSegment Height { get; private set; }
		public Rectangle(LineSegment width, LineSegment height)
		{
			Width = width;
			Height = height;
		}

		public override double Square()
		{
			return Width.Length * Height.Length;
		}

	}
}
