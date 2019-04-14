using System;
using System.Collections.Generic;
using System.Text;

namespace SocketLeakDetection
{
    public class Messages
    {
        public class TcpCount { }
        public class TimerExpired { }
        public class Status { public int curretStatus { get; set; } }
    }
}
