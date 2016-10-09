using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFMSMQ
{
	[ServiceContract]
	interface IService
	{
		[OperationContract(IsOneWay =true)]
		void Process(string data);
	} 

	[ServiceBehavior]
	public class MSMQService : IService
	{
		[OperationBehavior]
		public void Process(string data)
		{
			Console.WriteLine(String.Format("Process data {0} at {1}", data, DateTime.Now));
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost hotsname = new ServiceHost(typeof(MSMQService));
			hotsname.Open();
			Console.WriteLine("Service is ready");
			Console.ReadLine();
		}
	}
}
