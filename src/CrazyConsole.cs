using System;
using System.Text.RegularExpressions;
using static Retyped.dom;

namespace CrazyWebsite
{
    public static class CrazyConsole
    {
        private static HTMLDivElement _div;
        private static string _text;
        private static int _pos;

        static CrazyConsole()
        {
            _div = new HTMLDivElement();
            _text = string.Empty;
            _pos = 0;

            document.body.appendChild(_div);
        }

        public static void Flush()
        {
            if (_pos >= _text.Length)
            {
                _div.innerHTML = _text;
            }
            else
            {
                _div.innerHTML = _text.Substring(0, _pos);
                _pos += (new Random()).Next(1, 10);

                setTimeout((e) => Flush(), 5);
            }
        }

        public static int InfoSpacing { get; set; }

        public static void Write(string text)
        {
            _text += text;
        }

        public static void WriteLine(string line = string.Empty)
        {
            Write(line + "<br>");
        }

        public static void WriteInfo(string subject, string value, string link = string.Empty)
        {
            var valueinfo = value;
            if (!string.IsNullOrWhiteSpace(link))
                valueinfo = "<a href='" + link + "'>" + valueinfo + "</a>";

            WriteLine((subject + ": ").PadRight(InfoSpacing, '.') + " " + valueinfo);
        }

        public static void BeginCategory(string title)
        {
            CrazyConsole.WriteLine("[" + title + "]");
            CrazyConsole.WriteLine();
        }

        public static void EndCategory()
        {
            if (!_text.EndsWith("<br><br>"))
                CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();
        }

        public static void WriteWork(string title, string description, string workescription, string website, string refmail = string.Empty)
        {
            CrazyConsole.WriteLine("[" + title + "]");
            CrazyConsole.WriteLine(" - " + description);
            CrazyConsole.WriteLine(" - " + workescription);
            CrazyConsole.WriteLine(" - <a href='" + website + "'>" + website.Substring(website.IndexOf("//") + 2).TrimEnd('/') + "</a>");
            if (!string.IsNullOrWhiteSpace(refmail))
                CrazyConsole.WriteLine(" - " + refmail);

            CrazyConsole.WriteLine();
        }
    }
}
