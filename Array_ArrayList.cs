using System;

class Program
{
	static void Main()
	{
		// Array Creation
		int[] intArray = new int[] { 1, 2, 3, 4, 5 };

		// Accessing Elements
		int firstElement = intArray[0]; // 1

		// Length of Array
		int arrayLength = intArray.Length; // 5

		// Output with Comments
		Console.WriteLine("First Element of Array: " + firstElement); // First Element of Array: 1
		Console.WriteLine("Array Length: " + arrayLength); // Array Length: 5
	}
}

using System;
using System.Collections;

class Program
{
	static void Main()
	{
		// ArrayList Creation
		ArrayList arrayList = new ArrayList();
		arrayList.Add("Hello");
		arrayList.Add("world!");

		// Accessing Elements
		string firstString = (string)arrayList[0]; // "Hello"

		// Count of ArrayList
		int arrayListCount = arrayList.Count; // 2

		// Adding Elements to ArrayList
		arrayList.Add("C#");

		// Removing Elements from ArrayList
		arrayList.Remove("world!");

		// Output with Comments
		Console.WriteLine("First String in ArrayList: " + firstString); // First String in ArrayList: Hello
		Console.WriteLine("ArrayList Count: " + arrayListCount); // ArrayList Count: 2
	}
}
