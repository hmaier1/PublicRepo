using System;
using System.Collections.Generic;

namespace courseclass
{

	class TestCourse
	{
		static void Main ()
		{
			courseclass class1 = new courseclass(5656, 4, "CSE", "");
			courseclass class2 = new courseclass(2345, 4, "MATH", "Descrete Math using sets and theory");
			courseclass class3 = new courseclass(6262, 3, "MATH","");
			courseclass class4 = new courseclass(5555, 3, "CS","");
			/*
			string a = "Course #: " + class1.ncourseNum + "\nPrefix: " + class1.nprefix;
			string b = "\nCredit Hours: " + class1.ncreditHrs + "\n" + class1.ndescription;
			string x = "Course #: " + class2.ncourseNum + "\nPrefix: " + class2.nprefix;
			string y = "\nCredit Hours: " + class2.ncreditHrs + "\n" + class2.ndescription;


			Console.WriteLine(a + b);
			Console.WriteLine(x + y); */

			List<courseclass> courses = new List<courseclass>();
			courses.Add (class1);
			courses.Add (class2);
			courses.Add (class3);
			courses.Add (class4);

			Console.WriteLine ("Type add to add new course");
			Console.WriteLine ("Type remove to remove course");
			Console.WriteLine ("Type print to print all courses");
			Console.WriteLine ("Type exit to exit");

			string choice = Console.ReadLine();

			while (choice != "exit")

			{
			if(choice.Equals ("add")){
				Console.WriteLine ("Enter the course number.");
				int tempCNum = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter the credit hours.");
				int tempHrs = int.Parse(Console.ReadLine());

				Console.WriteLine ("Enter the prefix.");
				string tempPre = Console.ReadLine();

				Console.WriteLine("Enter the description.");
				string tempDes = Console.ReadLine();
				courses.Add(new courseclass (tempCNum, tempHrs, tempPre, tempDes));

			Console.WriteLine ("Type add to add new course");
			Console.WriteLine ("Type remove to remove course");
			Console.WriteLine ("Type print to print all courses");
			Console.WriteLine ("Type exit to exit");

			choice = Console.ReadLine();

			}
			else if (choice.Equals("remove"))
			{Console.WriteLine("Enter the index number of the class you want to remove");
				int index = int.Parse(Console.ReadLine());
				if (index >= 0 && courses.Count != 0 && index < courses.Count)
					{courses.RemoveAt(index);}
			Console.WriteLine ("Type add to add new course");
			Console.WriteLine ("Type remove to remove course");
			Console.WriteLine ("Type print to print all courses");
			Console.WriteLine ("Type exit to exit");

			choice = Console.ReadLine();

			}
			else if (choice.Equals("print")){
					foreach (courseclass com in courses){Console.WriteLine(com);}
			Console.WriteLine ("Type add to add new course");
			Console.WriteLine ("Type remove to remove course");
			Console.WriteLine ("Type print to print all courses");
			Console.WriteLine ("Type exit to exit");

			choice = Console.ReadLine();
			}
		}	
	}
}}

