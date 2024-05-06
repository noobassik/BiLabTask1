using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiLabTask3
{
	public abstract class Figure
	{
		// Виртуальный метод получается без реализации, было бы логичнее Figure сделать интерфейсом IFigure, 
		// но задание требует абстрактный класс.
		public abstract double Square();
	}
}
