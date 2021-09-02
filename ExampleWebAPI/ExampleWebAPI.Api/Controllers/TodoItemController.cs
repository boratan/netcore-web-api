using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : BaseController
    {
        // All class constructors, initialize, terminate and dispose methods.
        #region Construct / Init / Terminate / Dispose
        #endregion

        #region Methods

        // GET: api/<TodoItemController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TodoItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        #endregion

        // Properties for this class.
        #region Properties
        #endregion


        // All protected / private methods for this class.
        #region Helper methods
        #endregion

        // Private fields
        #region Fields
        #endregion
    }
}
