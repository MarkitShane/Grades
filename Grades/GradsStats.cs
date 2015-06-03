using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	class GradStatistics
	{

		public GradStatistics()
		{
			HighGrade = 0;
			LowGrade = float.MaxValue;
		}
		public float AverageGrade;
		public float HighGrade;
		public float LowGrade;
	}
}
