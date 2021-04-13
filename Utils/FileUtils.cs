using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MinoSharp.Utils
{
    public class FileUtils
    {
        public static void SaveFileFromResponse(HttpWebResponse response, string path)
        {
            using (BinaryReader reader = new BinaryReader(response.GetResponseStream()))
            {
                byte[] contentBytes = reader.ReadBytes(1 * 1024 * 1024 * 10);
                using (FileStream fStream = new FileStream(path, FileMode.Create))
                {
                    fStream.Write(contentBytes, 0, contentBytes.Length);
                }
            }
        }

        public static byte[] GetBytesFromResponse(HttpWebResponse response)
        {
            using (BinaryReader reader = new BinaryReader(response.GetResponseStream()))
            {
                return reader.ReadBytes(1 * 1024 * 1024 * 10);
            }
        }
    }
}
