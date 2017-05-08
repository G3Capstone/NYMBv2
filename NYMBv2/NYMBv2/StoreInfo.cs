using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYMBv2
{
    class StoreInfo
    {
        public string _storename { get; set; }

        public string _owners { get; set; }

        public string _location { get; set; }

        public string _phone { get; set; }

        public string _hours { get; set; }

        public string _description { get; set; }


        public StoreInfo()
        {
        }

        public StoreInfo(string s, string o, string l,
                         string p, string h, string d)
        {
            _storename = s;
            _owners = o;
            _location = l;
            _phone = p;
            _hours = h;
            _description = d;
            
        }

    }
}
