using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
	class TestUser
	{
		static void Main(string[] args)
		{
			User obj1 = User.GetInstance();
			User obj2 = User.GetInstance();

			Console.WriteLine(obj1.GetHashCode());
			Console.WriteLine(obj2.GetHashCode());
		}
	}
}
