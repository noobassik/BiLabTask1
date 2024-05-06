using BiLabTask3;
using System.ComponentModel.DataAnnotations;

namespace Task3Tests
{
	public class RectangleTests
	{
		[Theory]
		[InlineData(0, 1)]
		[InlineData(1, 0)]
		[InlineData(1, -2)]
		[InlineData(-1, 2)]
		public void InvalidSidesThrowsArgumentException(double width, double height)
		{
			Assert.Throws<ArgumentException>(() =>
				new Rectangle(new LineSegment(width), new LineSegment(height)));
		}

		[Theory]
		[InlineData(3, 4, 12)]
		[InlineData(6, 8, 48)]
		[InlineData(5, 5, 25)]
		public void RectangleAreaValidSides(double width, double height, double expectedArea)
		{
			Rectangle rectangle = new(new LineSegment(width), new LineSegment(height));

			double area = rectangle.Square();

			Assert.Equal(expectedArea, area, 2);
		}
	}
}
