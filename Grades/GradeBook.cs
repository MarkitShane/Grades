using System;
using System.Collections.Generic;

namespace Grades
{
	class GradeBook
	{


		public GradeBook()
		{
			grades = new List<float>();
		}

		public void AddGrade (float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				grades.Add(grade);
			}
		}

		public GradStatistics ComputeStatistics()
		{
			GradStatistics stats = new GradStatistics();

			float sum = 0f;
			foreach (float grade in grades)
			{
				stats.HighGrade = Math.Max(grade, stats.HighGrade);
				stats.LowGrade = Math.Min(grade, stats.LowGrade);
				sum += grade;
			}

			stats.AverageGrade = sum / grades.Count;
			return stats;
		}
		public string Name;

		private List<float> grades;
	}
}
