using PassionTea.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Objects
{
    class ModelFormCheckOutPage
    {
        public string EmailID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public string CardType { get; set; }

        public string CardNumber { get; set; }
        public string CardHoldName { get; set; }
        public int VerificationCode { get; set; }
    }
}
