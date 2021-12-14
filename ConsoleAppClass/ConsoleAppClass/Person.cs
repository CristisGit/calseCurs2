using System;

public class Classes1
{

	//1/ first name, last Name, birthYear, in constructor
	// sunt read-only
	//2. Expose FirstName intr-o proprietate
	// 3. expose a propriety named Age, that computes the age of the person

	readonly string _FirstName;
	readonly string _LastName;
	readonly DateTime _birthDate;

	
	public FirstName()
	{
		get 
			{ return _FirstName;  }
	}

	public int Age
	{
		get
		{
			return DateTime.Now.Year - _birthDate.Year;
		}
	}

}
