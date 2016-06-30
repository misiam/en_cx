using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Interfaces
{
    public interface IHttpClientContainer
    {
        HttpWebRequest Request { get; }
        HttpWebResponse Response { get; }
        bool UseGzipEncoding { get; }

        string GetResponseString();
    }
}
