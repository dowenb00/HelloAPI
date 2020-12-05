using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API3.Controllers
{
    public class HelloController : ApiController
    {
        // GET: Hello
        public string Get(string name)
        {
            return "Hello " + name;
        }
    }
}