using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	public class StandardGradeBook : BaseGradeBook
	{
		public string Name { get; set; }

		public StandardGradeBook (string name, bool isWeighted) : base(name, isWeighted)
		{
			Type = Enums.GradeBookType.Standard;
		}
	}
}
