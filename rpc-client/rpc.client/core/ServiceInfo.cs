using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpc_client.rpc.client.core
{
    class ServiceInfo : Attribute
    {
        public string value { get; }

        public ServiceInfo(string value) {
            this.value = value;
        }
    }
}
