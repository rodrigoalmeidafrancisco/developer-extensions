using System.IO;
using System.Net;
using System.Net.Http;

namespace Developer.HttpCore
{
    public class ResultHttp
    {
        public ResultHttp()
        {
            Success = true;
            DataString = null;
            DataBytes = null;
        }

        public bool Success { get; set; }

        public string Message { get; set; }

        public HttpResponseMessage Response { get; set; }

        public HttpStatusCode HttpStatusCode { get; set; }

        public string DataString { get; set; }

        public byte[] DataBytes { get; set; }

        public Stream DataStream { get; set; }

        public bool RequestRejected { get; set; }
    }
}
