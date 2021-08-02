using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPISL.Controllers
{
    public class DefaultController : ApiController
    {
        //Post
        public string Post( [FromBody]string value){
                return "Post";
            }
        //Put
        public void Put(int id,[FromBody]string value)
        {

        }
    }
}
