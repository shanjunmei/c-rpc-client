using rpc_client.rpc.client.core;
using rpc_client.rpc.client.test.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpc_client.rpc.client.test
{
    public interface op
    {
        [Api("ta/1") ]
        [ServiceInfo("http://45.78.17.151/")]
          object requestX(User usr);
    }
}
