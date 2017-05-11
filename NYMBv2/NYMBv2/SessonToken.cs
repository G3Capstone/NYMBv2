using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYMBv2
{
    class SessonToken
    {

        public string _UserName { get; set; }

        public string _UserLevel { get; set; }

        public string _Email { get; set; }

        public string _FirstName { get; set; }

        public string _LastName { get; set; }

        public SessonToken()
        {
        }

        public SessonToken(string userName, string userLevel, string Email,
                         string FirstName, string LastName)
        {
            _UserName = userName;
            _UserLevel = userLevel;
            _Email = Email;
            _FirstName = FirstName;
            _LastName = LastName;

        }

    }
}
