using Castle.DynamicProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace rpc_client.rpc.client.core
{
    class Proxy : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            MethodInfo method = invocation.Method;
            string command = method.Name;
            Api api=method.GetCustomAttribute<Api>();
            if (api != null) {
                if (!String.IsNullOrEmpty(api.command)) {
                    command = api.command;
                }
                
            }

            
            object[] param = invocation.Arguments;

            ServiceInfo serviceInfo = method.GetCustomAttribute<ServiceInfo>();
            string baseInfo = serviceInfo.value;
            string response=remoteInvoke(baseInfo+"/"+command, param);

           
            Type returnType=method.ReturnType;
            System.Console.WriteLine(response);
            invocation.ReturnValue = convert2entity(response, returnType);



        }

        public string remoteInvoke(string api, object obj) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
            //request.ContentType = "";
            //StreamWriter writer = new StreamWriter(request.GetRequestStream(),System.Text.UTF8Encoding.UTF8);

           // writer.Write(convert2json(obj));

            WebResponse response= request.GetResponse();

            StreamReader reader=new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
                     
        }

        public string convert2json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

       
        public object convert2entity(string json,Type type) {
            return JsonConvert.DeserializeObject(json, type);
        }
    }
}
