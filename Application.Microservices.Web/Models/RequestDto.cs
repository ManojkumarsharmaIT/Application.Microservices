
using Application.Microservices.Web.Utility;
using static Application.Microservices.Web.Utility.SD;

namespace Application.Microservices.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

        public ContentType ContentType { get; set; }=ContentType.Json;
    }
}
