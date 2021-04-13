using System;
using MinoSharp.API;
using System.Net;
using System.IO;
using System.Text;
using MinoSharp.Utils;

namespace MinoSharpLib
{
    public class MinoSharp
    {
        public static byte[] GetItem(string username, int size, ITEMS_COLLECTION item, IMAGE_FORMATS format)
        {
            string mainUrl = ApiUtils.IdentifyItem(item);
            string imageFormat = ApiUtils.IdentifyImageFormat(format);
            string[] args = ApiUtils.GetArgs(mainUrl, username, size, imageFormat, item);
            return FileUtils.GetBytesFromResponse(api.Request(args));
        }

        public static void SaveItem(string username, string path, int size, ITEMS_COLLECTION item, IMAGE_FORMATS format)
        {
            string mainUrl = ApiUtils.IdentifyItem(item);
            string imageFormat = ApiUtils.IdentifyImageFormat(format);
            string[] args = ApiUtils.GetArgs(mainUrl, username, size, imageFormat, item);
            FileUtils.SaveFileFromResponse(api.Request(args), path);

        }



    }
}

