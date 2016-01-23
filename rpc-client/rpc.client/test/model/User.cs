using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpc_client.rpc.client.test.model
{
   public  class User
    {
        public User()
        {
        }
        public User(String id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public string id { set; get; }
        public string name { set; get; }
    }
}
