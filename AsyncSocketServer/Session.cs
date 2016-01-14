using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSocketServer
{
    public static class Session
    {

        public static int Connections { get; set; }

        public static int RequestCounter { get; set; }

        public static int ResponseCounter { get; set; }


    }
}
