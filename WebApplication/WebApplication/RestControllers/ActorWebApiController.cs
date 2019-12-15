using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.RestControllers
{
    [RoutePrefix("api/actor")]
    public class ActorWebApiController : ApiController
    {
        private TheaterContext theaterContext = new TheaterContext();

        // GET api/<controller>
        [HttpGet]
        [Route("")]
        public IEnumerable<string> GetExamplesForActor()
        {
            return new string[] { "first actor", "second actor" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{id:int}")]
        public string GetFirstActor(int id)
        {
            return "first actor";
        }

        [HttpGet]
        [Route("{all}")]
        public IQueryable<Actor> GetAllActors()
        {
            //This returns all the actors were saved into the database
            return theaterContext.Actor;            
        }

        // POST api/<controller>    
        [HttpPost]    
        [Route("")]
        public String value([FromBody]string value)
        {
            return "Returning your value: " + value;
        }

     
    }
}