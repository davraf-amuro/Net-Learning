using Microsoft.AspNetCore.Mvc;

namespace MinimalApi.DTO
{
    public abstract class BaseSearchParameters
    {
        [FromHeader(Name = PublicConstants.XGuid)]
        public Guid RequestId { get; set; }

        public HttpRequest httpRequest { get; set; }

    }
}
