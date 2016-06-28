using System;
using System.Net;
using System.IO;

public class SeparateFunctonality
{
    public string EditLevelName()
    {
        string url = "http://demo.en.cx/Administration/Games/NameCommentEdit.aspx" + "?gid=25186&level=1";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/NameCommentEdit.aspx?action=view&gid=25186&level=1&refresh=1";
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

    public string EditLevelNameSave(string levelName, string levelDescription)
    {
        string url = "http://demo.en.cx/Administration/Games/NameCommentEdit.aspx" + "?gid=25186&level=1";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/NameCommentEdit.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "btnUpdate.x=31&btnUpdate.y=10&txtLevelComment=" + levelDescription + "&txtLevelName=" + levelName + "";
        using (StreamWriter writer = new StreamWriter(req.GetRequestStream()))
        {
            writer.Write(postData);
            writer.Flush();
        }

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