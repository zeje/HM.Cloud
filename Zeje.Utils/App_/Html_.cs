using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Zeje.Utils
{
    /// <summary>Html辅助类
    /// </summary>
    public class Html_
    {

        /// <summary>替换html字符
        /// </summary>
        /// <param name="strHtml"></param>
        /// <returns></returns>
        public static string EncodeHtml(string strHtml)
        {
            if (strHtml != "")
            {
                strHtml = strHtml.Replace(",", "&def;");
                strHtml = strHtml.Replace("'", "&dot;");
                strHtml = strHtml.Replace("\"", "&quot;");
                strHtml = strHtml.Replace(";", "&dec;");
                strHtml = strHtml.Replace("<", "&lt;");
                strHtml = strHtml.Replace(">", "&gt;");
                strHtml = strHtml.Replace(" ", "&nbsp;");
                return strHtml;
            }
            return "";
        }
        /// <summary>为脚本替换特殊字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReplaceStrToScript(string str)
        {
            if (str == string.Empty) return string.Empty;
            str = str.Replace("\\", "\\\\");
            str = str.Replace("'", "\\'");
            str = str.Replace("\"", "\\\"");
            str = str.Replace("\r\n", "\\r\\n");
            str = str.Replace("\n", "\\n");
            return str;
        }
        /// <summary>移除Html标记
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RemoveHtml(string content)
        {
            string regexstr = @"<[^>]*>";
            return EncodeHtml(Regex.Replace(content, regexstr, string.Empty, RegexOptions.IgnoreCase));
        }
        /// <summary>过滤HTML中的不安全标签
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RemoveUnsafeHtml(string content)
        {
            content = Regex.Replace(content, @"(\<|\s+)o([a-z]+\s?=)", "$1$2", RegexOptions.IgnoreCase);
            content = Regex.Replace(content, @"(script|frame|form|meta|behavior|style)([\s|:|>])+", "$1.$2", RegexOptions.IgnoreCase);
            return content;
        }
        /// <summary>从HTML中获取文本,保留br,p,img
        /// </summary>
        /// <param name="HTML"></param>
        /// <returns></returns>
        public static string GetTextFromHTML(string HTML)
        {
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex(@"</?(?!br|/?p|img)[^>]*>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            return regEx.Replace(HTML, "");
        }
    }
}
