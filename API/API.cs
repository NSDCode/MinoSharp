using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MinoSharp.API
{
    public class api
    {
        public const string _apiUrl = "https://minotar.net/";
        public const string _avatarUrl = "avatar/";
        public const string _helmetAvatarUrl = "helm/";
        public const string _cubeHeadUrl = "cube/";
        public const string _bodyUrl = "body/";
        public const string _bustUrl = "bust/";
        public const string _skinUrl = "skin/";

        public static HttpWebResponse Request(string[] args)
        {
            string _requestUrl = _apiUrl;
            for (int i = 0; i < args.Length; i++) { _requestUrl += args[i]; }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(_requestUrl);
            return (HttpWebResponse)req.GetResponse();

            
        }
    }
}
