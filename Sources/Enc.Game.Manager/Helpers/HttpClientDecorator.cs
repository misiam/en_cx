using Enc.Game.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace Enc.Game.Manager.Helpers
{
    public class HttpClientDecorator : IHttpClientDecorator
    {
        private string _response;
        public HttpClientDecorator(HttpWebRequest request, bool useGzipEncoding)
        {
            Request = request;
            this.UseGzipEncoding = useGzipEncoding;
        }

        public HttpWebRequest Request { get; private set; }
        public HttpWebResponse Response { get; private set; }
        public bool UseGzipEncoding { get; set; }

        public async Task SendHttpRequest(string postData = null)
        {
            await this.SendHttpRequest(this.Request, postData);
        }

        public async Task GetHttpResponse()
        {
            var response = await this.GetHttpResponse(this.Request);
            this.Response = response;
        }

        public string GetResponseString()
        {
            this._response = this._response ?? 
                this.GetResponseString(this.Response);
            return this._response;
        }

        public async Task SendHttpRequest(HttpWebRequest req, string postData = null)
        {
            using (var writer = new StreamWriter(await req.GetRequestStreamAsync()))
            {
                if (!string.IsNullOrEmpty(postData))
                {
                    writer.Write(postData);
                }
                writer.Flush();
            }
        }

        public async Task<HttpWebResponse> GetHttpResponse(HttpWebRequest req)
        {
            var webResponse = (HttpWebResponse)await req.GetResponseAsync();
            return webResponse;
        }

        public string GetResponseString(HttpWebResponse webResponse)
        {
            string response;
            using (Stream decompressed = this.UseGzipEncoding ? 
                new GZipStream(webResponse.GetResponseStream(), CompressionMode.Decompress) 
                : webResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(decompressed))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }
    }
}
