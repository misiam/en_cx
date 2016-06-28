using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Clients
{
    public class CommonFunctionalityClient : GameClient
    {
        private bool _runAsync = false;
        private bool _useGZip = false;

        public CommonFunctionalityClient(CookieContainer cookies, string appUrl = "http://demo.en.cx/") : base(cookies, appUrl)
        {
            // TODO: ADD UNIT TESTS !!!!!!
        }

        private async Task SendHttpRequest(HttpWebRequest req, string postData = null)
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
        private void SendHttpRequestSync(HttpWebRequest req, string postData = null)
        {
            var task = this.SendHttpRequest(req, postData);
            task.Wait();
        }
        private async Task<HttpWebResponse> GetHttpResponse(HttpWebRequest req)
        {
            var webResponse = (HttpWebResponse)await req.GetResponseAsync();
            return webResponse;
        }

        private HttpWebResponse GetHttpResponseSync(HttpWebRequest req)
        {
            var task = this.GetHttpResponse(req);
            task.Wait();
            return task.Result;
        }
        private string GetResponseString(HttpWebResponse webResponse)
        {
            string response;
            using (Stream decompressed = this._useGZip ? 
                new GZipStream(webResponse.GetResponseStream(), CompressionMode.Decompress) 
                : webResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }

        private void SetCookies(HttpWebRequest req)
        {
            req.CookieContainer = this.Cookies ?? new CookieContainer();
        }

        /// <summary>
        /// Cookies and the following properties are set:
        /// <list type="number">
        ///  <item><description>Accept</description></item>
        ///  <item><description>Headers["Cache-Control"]</description></item>
        ///  <item><description>Headers["Upgrade-Insecure-Requests"]</description></item>
        ///  <item><description>Headers["Accept-Encoding"]</description></item>
        ///  <item><description>Headers["Accept-Language"]</description></item>
        /// </list>
        /// </summary>
        /// <param name="url">Request URI string</param>
        /// <param name="httpMethod">HTTP method for the request</param>
        /// <returns></returns>
        private HttpWebRequest SetupRequest(string url, string httpMethod)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = httpMethod;

            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            req.Headers["Cache-Control"] = "max-age=0";
            req.Headers["Upgrade-Insecure-Requests"] = "1";
            req.Headers["Accept-Language"] = "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4";
            if (this._useGZip)
            {
                req.Headers["Accept-Encoding"] = "gzip, deflate";
            }
            this.SetCookies(req);

            return req;
        }

        public async Task<HttpWebResponse> LoginPost(string password, string username)
        {
            string url = this.AppUrl + "Login.aspx" + "?return=/Default.aspx";
            var req = this.SetupRequest(url, "POST");

            req.Headers["Origin"] = "http://demo.en.cx";
            req.ContentType = "application/x-www-form-urlencoded";

            string postData = "ddlNetwork=1&EnButton1=Р’С…РѕРґ&socialAssign=0&Login=" + username + "&Password=" + password + "";

            if (_runAsync)
            {
                await this.SendHttpRequest(req, postData);
            }
            else
            {
                this.SendHttpRequestSync(req, postData);
            }

            string response;
            //var webResponse = await this.GetHttpResponse(req);
            var webResponse = _runAsync ? await this.GetHttpResponse(req) : this.GetHttpResponseSync(req);
            response = this.GetResponseString(webResponse);
            int responseCode = (int)webResponse.StatusCode;

            return webResponse;
        }

        public async Task<string> LevelManagement(string gameId)
        {
            //http://demo.en.cx/Administration/Games/LevelManager.aspx?gid=25186
            string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=" + gameId + "";
            HttpWebRequest req = this.SetupRequest(url, "GET");

            // await this.SendHttpRequest(req);
            string response;
            var webResponse = this.GetHttpResponseSync(req);

            response = this.GetResponseString(webResponse);

            int responseCode = (int)webResponse.StatusCode;


            return response.ToString();
        }

    }
}
