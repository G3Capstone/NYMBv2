using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYMBv2
{
    class CreateUserObj
    {

        public string _username { get; set; }

        public string _password { get; set; }

        public string _confirmPassword { get; set; }

        public string _firstName { get; set; }

        public string _lastName { get; set; }

        public string _email { get; set; }

        public string _salt { get; set; }

        public string _hash { get; set; }


        public CreateUserObj(string u, string p, string cp,
                           string f, string l, string e)
        {
            _username = u;
            _password = p;
            _confirmPassword = cp;
            _firstName = f;
            _lastName = l;
            _email = e;
        }


    }
}
