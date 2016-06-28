using System;
using System.Net;
using System.IO;

public class HelpTopics
{
    public string ClassicCombatDescriptionHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=ClassicCombatDescription";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string TaskAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=TaskAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string MessageAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=MessageAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string PromptAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=PromptAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string PenaltyPromptAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=PenaltyPromptAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string BonusAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=BonusAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string AnswerAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=AnswerAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string FileAddingHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=FileAdding";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelManager.aspx?gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }

    public string LevelPassingSequenceHelp()
    {
        string url = "http://demo.en.cx/ALoader/Help.aspx" + "?about=LevelPassingSequence";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelManager.aspx?gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");


        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
        int responseCode = (int)resp.StatusCode;
        Console.WriteLine("Sending 'GET' request to URL : " + url);
        Console.WriteLine("Response Code : " + responseCode);

        string response;
        using (StreamReader input = new StreamReader(resp.GetResponseStream()))
        {
            response = input.ReadToEnd();
        }

        Console.WriteLine(response.ToString());

        return response.ToString();
    }


}