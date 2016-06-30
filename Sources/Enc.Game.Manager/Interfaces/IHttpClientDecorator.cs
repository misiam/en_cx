using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Interfaces
{
    public interface IHttpClientDecorator : IHttpClientContainer
    {

        Task SendHttpRequest(HttpWebRequest req, string postData = null);
        Task<HttpWebResponse> GetHttpResponse(HttpWebRequest req);
        string GetResponseString(HttpWebResponse webResponse);

        Task SendHttpRequest(string postData = null);
        Task GetHttpResponse();
    }
}
