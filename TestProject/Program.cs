using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
			// Create an array with five strings.
	        string[] array = new string[5];
	        array[0] = "carrot";
	        array[1] = "cucumber";
	        array[2] = "radish";
	        array[3] = "beet";
	        array[4] = "potato";
	        string[] array2 = new string[0];
			// Call the methods.
			string result1 = ConvertStringArrayToString(array2);
	        string result2 = ConvertStringArrayToStringJoin(array2);

	        //string value = "";
	        var v = (decimal)12.980484615384615;
	        v = decimal.Parse(v.ToString("0.0000"));
	        var v1 = (decimal)12.980454615384615;
	        v1 = decimal.Parse(v1.ToString("0.0000"));
	        var v2 = (decimal)12.980444615384615;
	        v2 = decimal.Parse(v2.ToString("0.0000"));
			Console.WriteLine(v);
	        Console.WriteLine(v1);
	        Console.WriteLine(v2);

			// Display the results.
			Console.WriteLine(result1);
	        Console.WriteLine(result2);
	        Console.Read();
        }

	    static string ConvertStringArrayToString(string[] array)
	    {
		    // Concatenate all the elements into a StringBuilder.
		    StringBuilder builder = new StringBuilder();
		    foreach (string value in array)
		    {
			    builder.Append(value);
			    builder.Append(value);
			    builder.Append('.');
		    }
		    return builder.ToString();
	    }

	    static string ConvertStringArrayToStringJoin(string[] array)
	    {
		    // Use string Join to concatenate the string elements.
		    string result = string.Join(".", array);
		    return result;
	    }
	}
}
