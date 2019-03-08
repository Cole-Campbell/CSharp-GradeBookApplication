using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
	{
		public string name { get; set; }
		public RankedGradeBook(string name) : base(name)
		{
			Type = Enums.GradeBookType.Ranked;
		}
	}
}
