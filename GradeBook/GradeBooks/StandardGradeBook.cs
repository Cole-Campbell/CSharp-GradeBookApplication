using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	public class StandardGradeBook : BaseGradeBook
	{
		public string Name { get; set; }

		public StandardGradeBook (string name) : base(name)
		{
			Type = Enums.GradeBookType.Standard;
		}
	}
}
