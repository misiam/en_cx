using System;
using System.Net;
using System.IO;

public class PenaltyPromptEditor
{
    public string PenaltyPromptCreate(string gameId, string penaltyPromptSeconds, string newPromptTimeoutMinutes, string penaltyNumber, string penaltyPromptMinutes, string newPromptTimeoutDays, string penaltyComment, string levelNumber, string newPromptTimeoutHours, string promptText, string penaltyPromptHours, string newPromptTimeoutSeconds, string PenaltyComment)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&penalty=" + penaltyNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?gid=25186&level=5&penalty=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "PenaltyPromptHours=" + penaltyPromptHours + "&ForMemberID=0&chkRequestPenaltyConfirm=" + PenaltyComment + "&txtPenaltyComment=" + penaltyComment + "&NewPromptTimeoutSeconds=" + newPromptTimeoutSeconds + "&btnAdd.y=11&PenaltyPromptSeconds=" + penaltyPromptSeconds + "&NewPrompt=" + promptText + "&btnAdd.x=39&NewPromptTimeoutDays=" + newPromptTimeoutDays + "&NewPromptTimeoutHours=" + newPromptTimeoutHours + "&NewPromptTimeoutMinutes=" + newPromptTimeoutMinutes + "&PenaltyPromptMinutes=" + penaltyPromptMinutes + "";
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

    public string PenaltyPromptView(string gameId, string penaltyId, string levelNumber, string penaltyNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&penalty=" + penaltyNumber + "&action=OpenerReload&prid=" + penaltyId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?gid=25186&level=5&penalty=1";
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

    public string PenaltyPromptEdit(string gameId, string penaltyId, string levelNumber, string penaltyNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&penalty=" + penaltyNumber + "&prid=" + penaltyId + "&action=PromptEdit";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?action=OpenerReload&gid=25186&level=5&penalty=1&prid=217997";
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

    public string PenaltyPromptUpdate(string gameId, string penaltyPromptSeconds, string penaltyId, string newPromptTimeoutMinutes, string penaltyNumber, string penaltyPromptMinutes, string newPromptTimeoutDays, string penaltyComment, string levelNumber, string newPromptTimeoutHours, string promptText, string penaltyPromptHours, string newPromptTimeoutSeconds)
    {
        string url = "http://demo.en.cx/Administration/Games/PromptEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&penalty=" + penaltyNumber + "&prid=" + penaltyId + "&action=PromptEdit";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/PromptEdit.aspx?prid=217997&action=PromptEdit&level=5&penalty=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "NewPrompt=" + promptText + "&PenaltyPromptHours=" + penaltyPromptHours + "&ForMemberID=0&NewPromptTimeoutDays=" + newPromptTimeoutDays + "&btnUpdate.x=37&NewPromptTimeoutHours=" + newPromptTimeoutHours + "&NewPromptTimeoutMinutes=" + newPromptTimeoutMinutes + "&txtPenaltyComment=" + penaltyComment + "&PenaltyPromptMinutes=" + penaltyPromptMinutes + "&btnUpdate.y=6&NewPromptTimeoutSeconds=" + newPromptTimeoutSeconds + "&PenaltyPromptSeconds=" + penaltyPromptSeconds + "";
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