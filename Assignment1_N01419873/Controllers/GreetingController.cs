using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01419873.Controllers
{
    public class GreetingController : ApiController
    {
        //Question 3 and 4 included in this controlller.
        //Post api/Greeting
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        // GET api/Greeting/{id}
        public string Get(int id)
        {
            string greeting = ("Greeting to" + " " + id + " " + "people!");
            return greeting;

        }
    }
}
