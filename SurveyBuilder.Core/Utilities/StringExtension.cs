using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SurveyBuilder.Core.Utilities
{
    public static class StringExtension
    {
        public static Random random = new Random();
        public static string RemoveVietnamese(this string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
            "đ",
            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
            "í","ì","ỉ","ĩ","ị",
            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "d",
            "e","e","e","e","e","e","e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
            "u","u","u","u","u","u","u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        public static string ConvertToSlug(this string text)
        {
            // Remove diacritics (accents) from Vietnamese characters
            text = RemoveVietnamese(text);

            // Replace spaces with hyphens and remove leading/trailing spaces
            string slug = Regex.Replace(text.Trim(), @"\s+", "-");

            // Replace special characters with hyphens
            slug = Regex.Replace(slug, @"[^a-zA-Z0-9\-]", "-");

            // Remove consecutive hyphens
            slug = Regex.Replace(slug, @"-+", "-");

            // Convert to lowercase
            slug = slug.ToLower();

            return slug;
        }

        public static string ToHash256(this string rawText)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawText));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string RandomString(int length)
        {
            var randomString = string.Empty;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            randomString = new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

        public static string ToEscape(this string htmlContent)
        {
            StringBuilder sb = new StringBuilder(htmlContent);
            sb.Replace("<script>", "&lt;script&gt;");
            sb.Replace("</script>", "&lt;/script&gt;");
            return sb.ToString();
        }
        public static bool IsMatch(this string text, string expression)
        {
            Regex re = new Regex(expression);
            return re.IsMatch(text);
        }
        
        public static string GetFolderFormatPath(this string path)
        {
            return path.Replace("/", @"\");
        }

        public static string GetWebFormatPath(this string path)
        {
            return path.Replace(@"\", "/");
        }


    }
}
