using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	class Program
	{
		static void GiveBookAName(GradeBook book)
		{
			book.Name = "The book";
		}

		static void IncrementNumber(int number)
		{
			number = 42;
		}

		static void Main(string[] args)
		{

			GradeBook g1 = new GradeBook();
			GradeBook g2 = g1;

			GiveBookAName(g1);
			Console.WriteLine(g1.Name);

			int x1 = 4;
			IncrementNumber(x1);
			Console.WriteLine(x1);

			//GradeBook book = new GradeBook();
			//book.AddGrade(91);
			//book.AddGrade(32.6f);
			//book.AddGrade(75f);


			//GradStatistics stats = book.ComputeStatistics();
			//Console.WriteLine(stats.AverageGrade);
			//Console.WriteLine(stats.LowGrade);
			//Console.WriteLine(stats.HighGrade);
			//Console.WriteLine();

		}
	}
}
