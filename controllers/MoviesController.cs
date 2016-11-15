
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace dotnetcore_angular2.controllers 
{

    [Produces("application/json")]
    [Route("api/Movies")]
    public class MoviesController : Controller 
    {
        // GET: api/Movies
        [HttpGet]
        public IEnumerable<string> GetMovie()
        {
            //return _context.Movies;
            return new string [] {"Star wars", "Jungle book", "Conjuring"};
        }
    }
}