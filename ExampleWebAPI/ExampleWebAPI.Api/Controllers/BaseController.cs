using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleWebAPI.Api.Controllers
{
    /// <summary>
    /// This contains basic functionality which can be used in derived controllers 
    /// used to provide a specific rest service contract.
    /// </summary>
    public class BaseController : ControllerBase
    {
        // All class constructors, initialize, terminate and dispose methods.
        #region Construct / Init / Terminate / Dispose

        /// <summary>
        /// Default constructor for class
        /// </summary>
        public BaseController()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
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
