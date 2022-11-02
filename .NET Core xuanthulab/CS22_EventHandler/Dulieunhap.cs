using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS22_EventHandler
{
    class Dulieunhap : EventArgs
    {
        public int data { get; set; }
        public Dulieunhap(int x) => data = x;

    }
}
