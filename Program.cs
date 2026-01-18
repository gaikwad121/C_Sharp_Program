using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Pratice_Codes
{
	public class Conv_One_Data_To_Other
	{
		public static void code()
		{
			string a = "123";
			int num = int.Parse(a); // num = 123
			Console.WriteLine(num);
			Console.WriteLine(num.GetType());
		}
	}
}

