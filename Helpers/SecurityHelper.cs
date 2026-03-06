using System.Text;

namespace Xcalibur.Weather.Models.Helpers
{
    /// <summary>
    /// Helper class for security-related functions.
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Encodes a plain text string to a Base64 encoded string using UTF8 encoding.
        /// </summary>
        /// <param name="plainText">The original plain text.</param>
        /// <returns>The Base64 encoded string.</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Decodes a Base64 encoded string back to a plain text string using UTF8 encoding.
        /// </summary>
        /// <param name="base64EncodedData">The Base64 encoded string.</param>
        /// <returns>The original plain text.</returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
