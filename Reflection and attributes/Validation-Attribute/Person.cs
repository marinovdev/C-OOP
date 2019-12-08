using static ValidationAttributes.MyRangeAttribute;

namespace ValidationAttributes
{
    internal class Person
    {
		private string fullName;
		private int age;

		public Person( string name, int age)
		{
			FullName = name;
			Age = age;
		}

		
		[MyRange(12, 90)]
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		[MyRequired]
		public string FullName
		{
			get { return fullName; }
			set { fullName = value; }
		}

	}
}