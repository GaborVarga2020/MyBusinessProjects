using System;

namespace JsonReadingExample
{
	class Program
	{
		static void Main(string[] args)
		{
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Empty.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
		}
	}
}
