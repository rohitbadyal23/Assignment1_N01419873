using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01419873.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/Square/{id}
        public int Get(int id)
        {
            int square = (id * id);
            return square;
        }
    }
}
