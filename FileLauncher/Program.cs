//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;

namespace Hello
{
	public class world
	{
		public static void Main(string[] args)
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();
			string line;

			// Read the file and display it line by line.  
			System.IO.StreamReader file = new System.IO.StreamReader(@"map.txt");
			while ((line = file.ReadLine()) != null)
			{
				//System.Console.WriteLine (line);
				string[] tokens = line.Split('=');

				// check tokens length
				if (tokens.Length >= 2)
				{
					dict.Add(Convert.ToInt32(tokens[0]), tokens[1]);

				}
				else
				{
					// bad line
				}

			}

			file.Close();
			// System.Console.WriteLine("There were {0} lines.", counter);  
			// Suspend the screen.  
			// System.Console.ReadLine();


			if (dict.Count > 0)
			{
				while (true)
				{
					// Nhap so
					Console.Write("Enter your number: ");
					String input = Console.ReadLine();
					int number = Convert.ToInt32(input);
					if (number > 0 && number <= dict.Count)
					{
						String filename = "";
						bool res = dict.TryGetValue(number, out filename);
						if (res && System.IO.File.Exists(filename))
						{
							System.Diagnostics.Process.Start(@filename);
						}
						else
						{
							Console.WriteLine("File not found!");
						}
					}
					else
					{
						// Nhap so 0 hoac so ko co trong map
						if (number == 0)
						{
							// Thoat chuong trinh
							Console.WriteLine("Exiting...");
							System.Threading.Thread.Sleep(1000);
							Environment.Exit(0);
						}
						else
						{
							Console.WriteLine("Bad input");
						}
					}
				}
			}
			else
			{
				// Khong co line nao
			}
		}
	}
}