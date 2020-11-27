using System;

namespace JsonReadingExample
{
	class Program
	{
		static void Main(string[] args)
		{
#if false
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
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - string.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.String);
						string strJsonValue = rootElement.GetString();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - 0.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						int nJsonValue = -1;
						nJsonValue = rootElement.GetInt32();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - 123456789.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						int nJsonValue = rootElement.GetInt32();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - -123456789.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						int nJsonValue = rootElement.GetInt32();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - 0.5.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						float nJsonValue = rootElement.GetSingle();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - 1E-3.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						float nJsonValue = rootElement.GetSingle();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - number - 1E+3.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Number);
						float nJsonValue = rootElement.GetSingle();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - boolean - false.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.False);
						bool bJsonValue = true;
						bJsonValue = rootElement.GetBoolean();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - boolean - true.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.True);
						bool bJsonValue = rootElement.GetBoolean();
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Single value - null.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Null);
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

#if false
			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Array - string.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Array);

						int nArrayLength = rootElement.GetArrayLength();

						for (int nArrayElementIndex = 0; nArrayElementIndex < nArrayLength; nArrayElementIndex++)
						{
							System.Text.Json.JsonElement jsonElementOfArray = rootElement[nArrayElementIndex];
							System.Diagnostics.Debug.Assert(jsonElementOfArray.ValueKind == System.Text.Json.JsonValueKind.String);
							string strColor = jsonElementOfArray.GetString();
						}
					}
				}
				catch (System.Exception exception)
				{
					System.Console.WriteLine(exception.Message);
				}
			}
#endif

			using (System.IO.FileStream jsonFileStream = new System.IO.FileStream("JsonFiles\\Object.json", System.IO.FileMode.Open))
			{
				try
				{
					using (System.Text.Json.JsonDocument jsonDocument = System.Text.Json.JsonDocument.Parse(jsonFileStream))
					{
						System.Text.Json.JsonElement rootElement = jsonDocument.RootElement;
						System.Diagnostics.Debug.Assert(rootElement.ValueKind == System.Text.Json.JsonValueKind.Object);
						System.Text.Json.JsonElement jsonElementAuthor = rootElement.GetProperty("Author");
						System.Diagnostics.Debug.Assert(jsonElementAuthor.ValueKind == System.Text.Json.JsonValueKind.String);
						string strAuthor = jsonElementAuthor.GetString();

						System.Text.Json.JsonElement jsonElementTitle = rootElement.GetProperty("Title");
						System.Diagnostics.Debug.Assert(jsonElementTitle.ValueKind == System.Text.Json.JsonValueKind.String);
						string strTitle = jsonElementTitle.GetString();

						System.Text.Json.JsonElement jsonElementPrice = rootElement.GetProperty("Price");
						System.Diagnostics.Debug.Assert(jsonElementPrice.ValueKind == System.Text.Json.JsonValueKind.Number);
						float nPrice = jsonElementPrice.GetSingle();

						System.Text.Json.JsonElement jsonElementTableOfContents = rootElement.GetProperty("TableOfContents");
						System.Diagnostics.Debug.Assert(jsonElementTableOfContents.ValueKind == System.Text.Json.JsonValueKind.Object);

						System.Text.Json.JsonElement jsonElementTableOfContentsItems = jsonElementTableOfContents.GetProperty("Items");
						System.Diagnostics.Debug.Assert(jsonElementTableOfContentsItems.ValueKind == System.Text.Json.JsonValueKind.Array);

						int nArrayLength = jsonElementTableOfContentsItems.GetArrayLength();

						for (int nArrayElementIndex = 0; nArrayElementIndex < nArrayLength; nArrayElementIndex++)
						{
							System.Text.Json.JsonElement jsonElementOfArray = jsonElementTableOfContentsItems[nArrayElementIndex];
							System.Diagnostics.Debug.Assert(jsonElementOfArray.ValueKind == System.Text.Json.JsonValueKind.String);
							string strChapter = jsonElementOfArray.GetString();
						}
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
