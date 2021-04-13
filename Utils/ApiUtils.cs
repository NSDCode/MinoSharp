using System;
using System.Collections.Generic;
using System.Text;
using MinoSharp.API;

namespace MinoSharp.Utils
{
    public class ApiUtils
    {
        public static string IdentifyItem(ITEMS_COLLECTION item)
        {
            switch (item)
            {
                case ITEMS_COLLECTION.BODY:
                    return api._bodyUrl;
                case ITEMS_COLLECTION.BUST:
                    return api._bustUrl;
                case ITEMS_COLLECTION.CUBE:
                    return api._cubeHeadUrl;
                case ITEMS_COLLECTION.HEAD:
                    return api._avatarUrl;
                case ITEMS_COLLECTION.HELMET:
                    return api._helmetAvatarUrl;
                case ITEMS_COLLECTION.SKIN:
                    return api._skinUrl;
                default:
                    return null;
            }
        }


        public static string IdentifyImageFormat(IMAGE_FORMATS format)
        {
            switch (format)
            {
                case IMAGE_FORMATS.JPG:
                    return ".jpg";
                case IMAGE_FORMATS.PNG:
                    return ".png";
                default:
                    return null;
            }
        }

        public static string[] GetArgs(string mainUrl, string username, int size, string imageFormat, ITEMS_COLLECTION item)
        {
            string[] args = null;
            if (item != ITEMS_COLLECTION.SKIN)
            {
                args = new string[]
                {
                    mainUrl,
                    $"{username}/",
                    size.ToString(),
                    imageFormat
                };
            }
            else
            {
                args = new string[]
            {
                    mainUrl,
                    username,
            };
            }
            return args;
        }

    }
}
