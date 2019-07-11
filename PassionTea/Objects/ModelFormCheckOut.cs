using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Objects
{
    class ModelFormCheckOut
    {
        public string EmailID { get; set; }
        public String Name { get; set; }

        public String Address { get; set; }

        public String CardType { get; set; }

        public String CardNumber { get; set; }
        public String CardHoldName { get; set; }
        public int VerificationCode { get; set; }
    }
}
