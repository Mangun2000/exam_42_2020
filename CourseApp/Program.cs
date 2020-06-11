using System;
					
public class Program
{
	public static void ElemWithIndex(string[] arr) {
		for (int i = 0; i < arr.Length; i++ ) {
			Console.WriteLine($"{i + 1}: {arr[i]}");
		}
	}
	
	public static void Main()
	{
		string[] myArray = new string[] { "слизни", "пиявки", "катышки из пупка гориллы", "брови гусеницы", "пальцы многоножки" };
		
		ElemWithIndex(myArray);
	}
}
