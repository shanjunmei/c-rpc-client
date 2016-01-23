using Newtonsoft.Json;
using rpc_client.rpc.client.core;
using rpc_client.rpc.client.test;
using rpc_client.rpc.client.test.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace rpc_client
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("", "");
            user.id = "test";
            user.name = "hello";



            op x = ProxyFactory.create<op>();


            object ret = x.requestX(user);
            System.Console.WriteLine(ret);

            System.Console.ReadLine();
        }
    }
}
