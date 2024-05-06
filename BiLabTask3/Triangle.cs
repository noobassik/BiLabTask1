using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiLabTask3
{
	public class Triangle : Figure
	{
		public LineSegment Side1 { get; private set; }

		public LineSegment Side2 { get; private set; }

		public LineSegment Side3 { get; private set; }

		public LineSegment[] Sides => new[] { Side1, Side2, Side3 };

		public Triangle(LineSegment firstSide, LineSegment secondSide, LineSegment thirdSide)
		{
			if (!TriangleValidation(firstSide, secondSide, thirdSide))
			{
				throw new ValidationException("Triangle with given sides can not exist");
			}
			Side1 = firstSide;
			Side2 = secondSide;
			Side3 = thirdSide;
		}

		public Triangle(LineSegment[] sides)
		{
			if (sides.Length != 3)
			{
				throw new ArgumentException("Amount of sides in array must be 3");
			}
			if (!TriangleValidation(sides[0], sides[1], sides[2]))
			{
				throw new ValidationException("Triangle with given sides can not exist");
			}
			Side1 = sides[0];
			Side2 = sides[1];
			Side3 = sides[2];
		}
		private static bool TriangleValidation(LineSegment firstSide, LineSegment secondSide, LineSegment thirdSide)
		{
			return firstSide.Length + secondSide.Length > thirdSide.Length &&
				   secondSide.Length + thirdSide.Length > firstSide.Length &&
				   firstSide.Length + thirdSide.Length > secondSide.Length;
		}

		public override double Square()
		{
			// S = sqrt(p(p-a)(p-b)(p-c))
			double p = (Side1.Length + Side2.Length + Side3.Length) / 2;
			return Math.Sqrt(p * (p - Side1.Length) * (p - Side2.Length) * (p - Side3.Length));
		}
	}
}
