using System;
using System.Net;
using System.IO;

public class PromptEditor
{
    public string PromptCreate(string gameId, string newPromptTimeoutDays, string propmtText, string levelNumber, string newPromptTimeoutMinutes, string newPromptTimeoutHours, string newPromptTimeoutSeconds)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?gid=25186&level=5";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "NewPrompt=" + propmtText + "&ForMemberID=0&btnAdd.x=34&NewPromptTimeoutDays=" + newPromptTimeoutDays + "&NewPromptTimeoutHours=" + newPromptTimeoutHours + "&NewPromptTimeoutMinutes=" + newPromptTimeoutMinutes + "&NewPromptTimeoutSeconds=" + newPromptTimeoutSeconds + "&btnAdd.y=5";
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

    public string PromptView(string gameId, string promptId, string levelNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&action=OpenerReload&prid=" + promptId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?gid=25186&level=5";
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

    public string PromptEdit(string gameId, string promptId, string levelNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&action=PromptEdit&prid=" + promptId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?action=OpenerReload&gid=25186&level=5&prid=217995";
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

    public string PromptUpdate(string gameId, string newPromptTimeoutDays, string promptId, string levelNumber, string newPromptTimeoutMinutes, string newPromptTimeoutHours, string promptText, string newPromptTimeoutSeconds)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&action=PromptEdit&prid=" + promptId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?gid=25186&action=PromptEdit&prid=217995&level=5";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "NewPrompt=" + promptText + "&ForMemberID=0&NewPromptTimeoutDays=" + newPromptTimeoutDays + "&btnUpdate.x=44&NewPromptTimeoutHours=" + newPromptTimeoutHours + "&NewPromptTimeoutMinutes=" + newPromptTimeoutMinutes + "&btnUpdate.y=5&NewPromptTimeoutSeconds=" + newPromptTimeoutSeconds + "";
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