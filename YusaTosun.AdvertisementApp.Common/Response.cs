using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YusaTosun.AdvertisementApp.Common
{
    public class Response:IResponse
    {
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }
        public Response(ResponseType responseType,string message)
        {
            ResponseType = responseType;
            Message = message;
        }
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
    }
    public enum ResponseType
    {
        Success,
        ValidationError,
        NotFound
    }
}
