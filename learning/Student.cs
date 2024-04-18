using System;
namespace learning
{
	class Student
	{
		public string name;
		public string major;
        public double gpa;

        public Student(string aName,string aMajor, double aGpa)
		{
			name = aName;
			major = aMajor;
			gpa = aGpa;

        }
		public bool HasHonors()
		{
			if(gpa >= 3)
			{
				return true;
			}
            return false;

        }
    }
}

