using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using LibraryWebAPI.Models;
using LibraryWebAPI.Data;

namespace LibraryWebAPI.Controllers
{
    //[Route("authorAPI")]
    public class AuthorController : ApiController
    {
        // GET api/<controller>
        public List<Author> Get()
        {
            return AuthorData.Listar();
        }

        // GET api/<controller>/5
        public Author Get(int id)
        {
            return AuthorData.Buscar(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Author author)
        {
            return AuthorData.Insert(author);
        }

        // PUT api/<controller>/5
        public bool Put(int id, [FromBody] Author author)
        {
            return AuthorData.Update(author);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return AuthorData.Delete(id);
        }
    }
}