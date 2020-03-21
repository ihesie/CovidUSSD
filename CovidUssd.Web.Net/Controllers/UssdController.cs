using CovidUssd.Web.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CovidUssd.Web.Net.Controllers
{
    [RoutePrefix("application/services")] // Your Application will be served as http(s)://<host>:port/application/services/...
    public class USSDServiceController : ApiController
    {
        [Route("ussdservice")]  // http(s)://<host>:port/application/services/ussdservice
        [HttpPost, ActionName("ussdservice")]

        public HttpResponseMessage httpResponseMessage([FromBody] UssdResponse ussdResponse)
        {
            HttpResponseMessage responseMessage;
            string response;

            if (ussdResponse.text == null)
            {
                ussdResponse.text = "";
            }

            response = responseObject.Menu(ussdResponse.text);
            responseMessage = Request.CreateResponse(HttpStatusCode.Created, response);

            responseMessage.Content = new StringContent(response, Encoding.UTF8, "text/plain");

            return responseMessage;
        }
    }
}

