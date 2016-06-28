using System;
using System.Net;
using System.IO;

public class CommonFunctionality
{
    public string OpenLogin()
    {
        string url = "http://demo.en.cx/Login.aspx" + "?return=/Default.aspx";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Default.aspx";
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

    public string LoginPost(string password, string username)
    {
        string url = "http://demo.en.cx/Login.aspx" + "?return=/Default.aspx";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Login.aspx?return=%2fDefault.aspx";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "ddlNetwork=1&EnButton1=Р’С…РѕРґ&socialAssign=0&Login=" + username + "&Password=" + password + "";
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

    public string LoginRedirect()
    {
        string url = "http://demo.en.cx/Login.aspx" + "?checkcookie=1&return=/Default.aspx";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Login.aspx?return=%2fDefault.aspx";
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

    public string OpenGameAdminPage()
    {
        string url = "http://demo.en.cx/AdminPanel.aspx" + "?";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Default.aspx";
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

    public string GameCreateChoosing()
    {
        string url = "http://demo.en.cx/Administration/Games/GameCreate.aspx" + "?type=own";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/AdminPanel.aspx";
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

    public string GameCreateChooseSingle(string gameType, string gameZone)
    {
        string url = "http://demo.en.cx/Administration/Games/GameCreate.aspx" + "?gametypeid=" + gameType + "&type=own&gamezonelist=" + gameZone + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?type=own";
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

    public string GameCreateChooseSinglePost(string gameTypeID, string ddlAuthorsCompexity, string hideGameFromCalendar, string fee, string isModerated, string feeCurrency, string firstPlaces, string gameTitle, string prize, string certificateMode, string notFirstPlaces, string gameStatAvailabilityList, string action, string gameAutorsByCommas, string requestLastDate, string chkShowFinishPlace, string radioAcceptRateMode, string maxPlayers, string maxTeamPlayers, string showFeeList, string gameZoneList, string finishDateTime, string gameScenarioAvailabilityList, string startDateTime, string txtAcceptRateFrom, string feeName, string descriptionHtml)
    {
        string url = "http://demo.en.cx/Administration/Games/GameCreate.aspx" + "?";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?gametypeid=0&type=own&gamezonelist=0";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "FirstPlaces=" + firstPlaces + "&ddlAuthorsCompexity=" + ddlAuthorsCompexity + "&NotFirstPlaces=" + notFirstPlaces + "&GameZoneList=" + gameZoneList + "&Descr=" + descriptionHtml + "&Tabs1_tabsContent_baseSettings_vp0=Tabs1_tabsContent_baseSettings_vp0&FeeName=" + feeName + "&MaxPlayers=" + maxPlayers + "&btnCreate.y=5&btnCreate.x=38&GameTitle=" + gameTitle + "&action=" + action + "&chkShowFinishPlace=" + chkShowFinishPlace + "&radioAcceptRateMode=" + radioAcceptRateMode + "&HideGameFromCalendar=" + hideGameFromCalendar + "&CertificateMode=" + certificateMode + "&Fee=" + fee + "&GameStatAvailabilityList=" + gameStatAvailabilityList + "&FinishDateTime=" + finishDateTime + "&RequestLastDate=" + requestLastDate + "&Prize=" + prize + "&GameTypeID=" + gameTypeID + "&MaxTeamPlayers=" + maxTeamPlayers + "&GameScenarioAvailabilityList=" + gameScenarioAvailabilityList + "&StartDateTime=" + startDateTime + "&ShowFeeList=" + showFeeList + "&txtAcceptRateFrom=" + txtAcceptRateFrom + "&GameAuthors=" + gameAutorsByCommas + "&IsModerated=" + isModerated + "&FeeCurrency=" + feeCurrency + "";
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

    public string LevelManagement(string gameId)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=" + gameId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?gametypeid=0&type=own&gamezonelist=0";
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

    public string DeleteGameConfirmation(string gameId, string actionName)
    {
        string url = "http://demo.en.cx/Administration/GamesManager.aspx" + "?gid=" + gameId + "&action=" + actionName + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelManager.aspx?gid=25161";
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

    public string DeleteGameConfirmed(string gameId, string pageNumber, string actionName)
    {
        string url = "http://demo.en.cx/Administration/GamesManager.aspx" + "?gid=" + gameId + "&action=" + actionName + "&page=" + pageNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/GamesManager.aspx?action=confirm_delete&gid=25161";
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

    public string GameCreateChooseTeam()
    {
        string url = "http://demo.en.cx/Administration/Games/GameCreate.aspx" + "?gametypeid=1&type=own&gamezonelist=0";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?type=own";
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

    public string GameCreate_Sample()
    {
        string url = "http://demo.en.cx/Administration/Games/GameCreate.aspx" + "?";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?gametypeid=1&type=own&gamezonelist=0";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "FirstPlaces=3&ddlAuthorsCompexity=10&cbIsGameShortDescrHided=on&NotFirstPlaces=3&GameZoneList=0&Descr=&Tabs1_tabsContent_baseSettings_vp0=Tabs1_tabsContent_baseSettings_vp0&FeeName=Р’Р·РЅРѕСЃ+Р·Р°+СѓС‡Р°СЃС‚РёРµ&MaxPlayers=0&btnCreate.y=3&btnCreate.x=36&GameTitle=someGame&action=create&GameAvailAfter=true&chkShowFinishPlace=true&radioAcceptRateMode=1&HideGameFromCalendar=on&CertificateMode=1&Fee=0,00&GameStatAvailabilityList=1&FinishDateTime=11.06.2016+22:00:00&RequestLastDate=&Prize=50&GameTypeID=0&MaxTeamPlayers=0&GameScenarioAvailabilityList=2&StartDateTime=10.06.2016+22:00:00&ShowFeeList=1&txtAcceptRateFrom=06.06.2016+22:00:00&GameAuthors=dummy_user&IsModerated=true&FeeCurrency=1";
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

    public string LevelManager_Sample()
    {
        string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=25186";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameCreate.aspx?gametypeid=1&type=own&gamezonelist=0";
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

    public string DeleteAttachedFIle(string gameId, string fileName)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=" + gameId + "&delfile=" + fileName + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
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

    public string ChangeLevelSequence(string gameId, string ddlLevelsSequence)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=" + gameId + "&btnLevelSequence.y=5&sequences=change&ddlLevelsSequence=" + ddlLevelsSequence + "&btnLevelSequence.x=21";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
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

    public string GameSettingsView(string gameId)
    {
        string url = "http://demo.en.cx/Administration/Games/GameEditor.aspx" + "?gid=" + gameId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
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

    public string GameSettingsEdit(string gameId)
    {
        string url = "http://demo.en.cx/Administration/Games/GameEditor.aspx" + "?gid=" + gameId + "&action=edit";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameEditor.aspx?gid=25186";
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

    public string GameSettingsConfirm(string gameAutors, string ddlAuthorsCompexity, string hideGameFromCalendar, string fee, string isModerated, string feeCurrency, string firstPlaces, string gameTitle, string prize, string certificateMode, string notFirstPlaces, string gameStatAvailabilityList, string requestLastDate, string chkShowFinishPlace, string gameId, string radioAcceptRateMode, string maxPlayers, string showFeeList, string finishDateTime, string gameScenarioAvailabilityList, string startDateTime, string txtAcceptRateFrom, string feeName, string descriptionHtml, string gameAvailAfter)
    {
        string url = "http://demo.en.cx/Administration/Games/GameEditor.aspx" + "?";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/GameEditor.aspx?action=edit&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "FirstPlaces=" + firstPlaces + "&gid=" + gameId + "&ddlAuthorsCompexity=" + ddlAuthorsCompexity + "&NotFirstPlaces=" + notFirstPlaces + "&Tabs1_tabsContent_baseSettings_vp1=Tabs1_tabsContent_baseSettings_vp1&Descr=" + descriptionHtml + "&FeeName=" + feeName + "&MaxPlayers=" + maxPlayers + "&GameTitle=" + gameTitle + "&action=update&GameAvailAfter=" + gameAvailAfter + "&chkShowFinishPlace=" + chkShowFinishPlace + "&radioAcceptRateMode=" + radioAcceptRateMode + "&HideGameFromCalendar=" + hideGameFromCalendar + "&CertificateMode=" + certificateMode + "&btnUpdate.x=50&Fee=" + fee + "&GameStatAvailabilityList=" + gameStatAvailabilityList + "&FinishDateTime=" + finishDateTime + "&RequestLastDate=" + requestLastDate + "&Prize=" + prize + "&GameScenarioAvailabilityList=" + gameScenarioAvailabilityList + "&StartDateTime=" + startDateTime + "&ShowFeeList=" + showFeeList + "&txtAcceptRateFrom=" + txtAcceptRateFrom + "&btnUpdate.y=10&GameAuthors=" + gameAutors + "&IsModerated=" + isModerated + "&FeeCurrency=" + feeCurrency + "";
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

    public string LevelEditor(string gameId)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
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

    public string LevelEditorAddNew()
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=25186&action=AddNewLevel";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186";
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

    public string LevelEditorAddNewFrom1()
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=25186&level=1&action=AddNewLevel";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
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

    public string LevelEditorSelectLevel(string gameId, string levelNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=4&gid=25186";
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

    public string AutoTransitionView(string gameId, string levelNumber, string objectNumber)
    {
        string url = "http://demo.en.cx/ALoader/LevelInfo.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&object=" + objectNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1";
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

    public string AutoTransitionWithPenaltySave(string autoTransitionMinutes, string penaltyHours, string penaltyMinutes, string autoTransitionSeconds, string autoTransitionHours, string penaltySeconds)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=gameId&level=levelNumber";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "ctl01_ctl00_ctl03.x=54&txtApHours=" + autoTransitionHours + "&txtApSeconds=" + autoTransitionSeconds + "&txtApPenaltySeconds=" + penaltySeconds + "&ctl01_ctl00_ctl03.y=16&chkTimeoutPenalty=on&txtApPenaltyMinutes=" + penaltyMinutes + "&updateautopass=&txtApPenaltyHours=" + penaltyHours + "&txtApMinutes=" + autoTransitionMinutes + "";
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

    public string AutoTransitionSave(string gameId, string autoTransitionMinutes, string autoTransitionSeconds, string autoTransitionHours, string levelNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "ctl01_ctl00_ctl03.x=40&txtApHours=" + autoTransitionHours + "&txtApSeconds=" + autoTransitionSeconds + "&ctl01_ctl00_ctl03.y=17&updateautopass=&txtApMinutes=" + autoTransitionMinutes + "";
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

    public string AttemptsBlock(string gameId, string attemptsPeriodHours, string attemptsNumber, string levelNumber, string attemptsPeriodMinutes, string attemptsPeriodSeconds)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "pnlSettings_AnswerBlockingSettings_ctl00_ctl08.x=42&pnlSettings_AnswerBlockingSettings_ctl00_ctl08.y=8&txtAttemptsPeriodHours=" + attemptsPeriodHours + "&txtAttemptsPeriodMinutes=" + attemptsPeriodMinutes + "&action=upansblock&txtAttemptsNumber=" + attemptsNumber + "&txtAttemptsPeriodSeconds=" + attemptsPeriodSeconds + "";
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

    public string AddAnswersAsSet(string gameId, string answer, string levelNumber, string userId)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?level=1&gid=25186";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "txtAnswer_5=&ddlAnswerFor_9=0&AnswersTable_ctl00_NewAnswerEditor_ctl00_btnSave.y=7&txtAnswer_6=&ddlAnswerFor_8=0&txtAnswer_7=&txtAnswer_8=&AnswersTable_ctl00_NewAnswerEditor_ctl00_btnSave.x=35&txtAnswer_1=ans2&txtAnswer_2=ans3&txtAnswer_3=&txtAnswer_4=&ddlAnswerFor_1=0&ddlAnswerFor_0=" + userId + "&ddlAnswerFor_3=0&ddlAnswerFor_2=0&ddlAnswerFor_5=0&txtAnswer_9=&ddlAnswerFor_4=0&ddlAnswerFor_7=0&ddlAnswerFor_6=0&saveanswers=1&txtAnswer_0=" + answer + "";
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

    public string AddAnswersAsSector(string answer2, string sectorName, string answer1)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=25186&level=1&swanswers=1";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1&swanswers=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "txtAnswer_5=&ddlAnswerFor_9=0&txtAnswer_6=&ddlAnswerFor_8=0&txtAnswer_7=&txtAnswer_8=&txtAnswer_1=" + answer2 + "&savesector=&txtAnswer_2=&txtAnswer_3=&txtAnswer_4=&ddlAnswerFor_1=0&btnSaveSector.y=11&ddlAnswerFor_0=0&ddlAnswerFor_3=0&ddlAnswerFor_2=0&btnSaveSector.x=16&ddlAnswerFor_5=0&txtAnswer_9=&ddlAnswerFor_4=0&ddlAnswerFor_7=0&ddlAnswerFor_6=0&txtSectorName=" + sectorName + "&txtAnswer_0=" + answer1 + "";
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

    public string EditAnswersAsSectorView(string gameId, string objectNumber, string levelNumber, string sectorNumber)
    {
        string url = "http://demo.en.cx/ALoader/LevelInfo.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&sector=" + sectorNumber + "&object=" + objectNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "*/*";
        req.Headers.Add("X-Requested-With", "XMLHttpRequest");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1&swanswers=1";
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

    public string DeleteAnswer(string gameId, string levelNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "POST";

        req.Headers.Add("Origin", "http://demo.en.cx");
        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Cache-Control", "max-age=0");
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1&swanswers=1";
        req.KeepAlive = true;
        req.Host = "demo.en.cx";
        req.Headers.Add("Accept-Encoding", "gzip, deflate");
        req.Headers.Add("Accept-Language", "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4");
        req.ContentType = "application/x-www-form-urlencoded";

        string postData = "btnDelete.x=44&txtAnswer_407909=ans3&btnDelete.y=11&updateanswers=210196&ddlAnswerFor_407907=0&chkDeleteAnswer_407908=407908&ddlAnswerFor_407909=0&ddlAnswerFor_407908=0&txtAnswer_407908=ans2&txtAnswer_407907=ans1";
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

    public string DeleteAnswersSector(string gameId, string levelNumber, string sectorNumber)
    {
        string url = "http://demo.en.cx/Administration/Games/LevelEditor.aspx" + "?gid=" + gameId + "&level=" + levelNumber + "&swanswers=1&delsector=" + sectorNumber + "";
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        req.Method = "GET";

        req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
        req.Headers.Add("Upgrade-Insecure-Requests", "1");
        req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
        req.Referer = "http://demo.en.cx/Administration/Games/LevelEditor.aspx?gid=25186&level=1&swanswers=1";
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