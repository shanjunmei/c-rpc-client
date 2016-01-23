using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpc_client.rpc.client.core
{
    public  class Api : Attribute
    {
        public string command { get; }
        public Api(string command)
        {
            this.command = command;
        }


    }
}
