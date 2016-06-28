using System;
using System.Net;
using System.IO;

public class MessageEdit
{
    public string LevelMessageCreate(string gameId, string levelNumber, string message, string rbShowOnLevels)
    {
        string url = "http://demo.en.cx/Administration/Games/MessageEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&action=add";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/MessageEdit.aspx?gid=25186&level=242265&action=add";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "txtMessage=" + message + "&chkReplaceNlToBr=@chkReplaceNlToBr@chkReplaceNlToBr&action=save&btnSave.x=41&btnSave.y=9&rbShowOnLevels=" + rbShowOnLevels + "";
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

    public string LevelMessageView()
    {
        string url = "http://demo.en.cx/Administration/Games/MessageEdit.aspx" + "?gid=25186&level=242265&action=reload&mid=1794";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/MessageEdit.aspx?gid=25186&level=242265&action=add";
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

    public string LevelMessageEdit(string gameId, string levelNumber, string messageId)
    {
        string url = "http://demo.en.cx/Administration/Games/MessageEdit.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&action=edit&mid=" + messageId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/MessageEdit.aspx?action=reload&gid=25186&level=242265&mid=1794";
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

    public string LevelMessageUpdate(string gameId, string chkReplaceNlToBr, string rbShowOnLevelsCount, string levelId, string isOn, string messageId, string message)
    {
        string url = "http://demo.en.cx/Administration/Games/MessageEdit.aspx" + "?gid=" + gameId + "&level=" + levelId + "&action=edit&mid=" + messageId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/MessageEdit.aspx?action=edit&gid=25186&level=242265&mid=1794";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "txtMessage=" + message + "&lvl_242263=" + isOn + "&chkReplaceNlToBr=" + chkReplaceNlToBr + "&btnUpdate.x=30&lvl_242262=" + isOn + "&action=update&btnUpdate.y=9&rbShowOnLevels=" + rbShowOnLevelsCount + "";
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