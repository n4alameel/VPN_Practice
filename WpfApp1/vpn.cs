using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class vpn
    {
        private string address;
        private bool state;
        public vpn(string add) {
            address = add;
            state = true;
        }
        public bool getState() { return state; }
        public void setState(bool st) { state = st; }

    } 
} 
