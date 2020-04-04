using ForestAPI.Errors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestAPI.Controllers
{
    public abstract class ExtendedApiController<T> : ControllerBase where T : class
    {
        // Service Object
        public T Service { get; }

        protected ExtendedApiController(T service)
        {
            Service = service;
        }

        // TODO: Return Custom IActionResult Error
        protected IActionResult Error(Error error)
        {
            return new ObjectResult(error)
            {
                StatusCode = error.StatusCode
            };
        }

        // Todo: Create Error handling
        protected async Task<IActionResult> InvokeRequest(Func<Task<IActionResult>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception e)
            {
                return Error(new Error(500, e.Message));
            }
        }
    }
}
