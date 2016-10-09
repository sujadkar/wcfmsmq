using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQClient
{
	class Program
	{
		static void Main(string[] args)
		{
			MSMQServiceReference.ServiceClient client = new MSMQServiceReference.ServiceClient();
			Console.WriteLine("Enter data to process");
			var data = Console.ReadLine();

			while(data != "Q")
			{
				client.Process(data);
				Console.WriteLine("Enter data to process");
				data = Console.ReadLine();
			}
		}
	}
}
