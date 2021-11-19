using HotChocolate;
using Microsoft.AspNetCore.Http;

namespace GraphQLTest
{
    public class Query
    {
        public Something getSomething([Service] IHttpContextAccessor contextAccessor)
        {
            Something result = null;

            if (result == null)
            {
                contextAccessor.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }

            return result;
        }
    }
}
