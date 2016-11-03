using System;
using System.Collections.Generic;

namespace courseclass
{
	class courseclass
	{
		private int courseNum;
		private int creditHrs;
		private string prefix;
		private string description;

		public int ncourseNum
		{
		get{return courseNum;} 
		set{courseNum = value;}
		}   
		public int ncreditHrs
		{
		get{return creditHrs;} 
		set{creditHrs = value;}
		} 
		public string nprefix
		{
		get{return prefix;} 
		set{prefix = value;}
		} 
		public string ndescription
		{
		get{return description;} 
		set{description = value;}
		} 

		public courseclass ()
		{
			courseNum = 0000;
			creditHrs = 3;
			prefix = "";
			description = "";
		}

		public courseclass (int courseNum, int creditHrs, string prefix, string description)
		{
			this.courseNum = courseNum;
			this.creditHrs = creditHrs;
			this.prefix = prefix;
			this.description = description;
		}
	}
}

