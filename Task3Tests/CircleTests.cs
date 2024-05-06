using BiLabTask3;


namespace Task3Tests
{
	public class CircleTests
	{
		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		public void InvalidRadiusThrowsArgumentException(double radius)
		{
			Assert.Throws<ArgumentException>(() => new Circle(new LineSegment(radius)));
		}

		[Theory]
		[InlineData(1, Math.PI)]
		[InlineData(5, 78.54)]
		[InlineData(10, 314.16)]
		public void CircleAreaValidRadius(double radius, double expectedArea)
		{
			Circle circle = new Circle(new LineSegment(radius));

			double area = circle.Square();

			Assert.Equal(expectedArea, area, 2);
		}
	}
}
