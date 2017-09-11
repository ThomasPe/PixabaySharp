using System;
using System.Collections.Generic;
using System.Text;

namespace PixabaySharp.Utility
{
    public static class HttpTools
    {
        public static string UriEncode(string s)
        {
            return Uri.EscapeUriString(s).Replace("%20", "+");
        }
    }
}
