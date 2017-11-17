using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TutorApi.Models;

namespace TutorApi.Controllers
{
    public class UsersController : ApiController
    {
        /// <summary>
        /// Get Users
        /// </summary>
        private TutionProEntities tutionProEntities = new TutionProEntities();
        // GET: api/Users
        public List<User> Get()
        {
           return tutionProEntities.Users.ToList();

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
