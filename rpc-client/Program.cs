using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.req;
using com.hzins.channel.api.model.resp;
using Newtonsoft.Json;
using rpc_client.rpc.client;
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


            OpenApiRemoteOperationTest.testProductList();

          
            System.Console.ReadLine();
        }
    }
}
