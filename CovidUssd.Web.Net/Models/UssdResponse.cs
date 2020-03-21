using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CovidUssd.Web.Net.Models
{

    public class UssdResponse
    {
        public string text { get; set; }
        public string phoneNumber { get; set; }
        public string sessionId { get; set; }
        public string serviceCode { get; set; }

    }

}