using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Model
{
    public partial class Packet
    {
        public override string ToString()
        {
            return PacketName; 
        }
    }
    public partial class Service
    {
        public override string ToString()
        {
            return ServiceNames;
        }
    }
}
