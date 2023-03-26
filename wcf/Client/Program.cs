using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        string[] GetMessages();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to const...");
            Console.ReadLine();
            string uri = "net.tcp://localhost:6565/MessageService";
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            var channel = new ChannelFactory<IMessageService>(binding);
            var endpoint = new EndpointAddress(uri);
            var proxy = channel.CreateChannel(endpoint);
            var result = proxy?.GetMessages();
            if (result != null)
                result.ToList().ForEach(p =>
                {
                    Console.WriteLine(p);
                });
        }
    }
}
