using System;

namespace PixabaySharp.Utility
{
    /// <summary>
    /// Helper class for <see cref="HttpHelper"/>
    /// </summary>
    public static class HttpTools
    {
        /// <summary>
        /// Encode an URI in the Pixabay style.
        /// </summary>
        /// <param name="s">String to encode</param>
        /// <returns>Encoded string</returns>
        public static string UriEncode(string s)
        {
            return Uri.EscapeUriString(s).Replace("%20", "+");
        }
    }
}
