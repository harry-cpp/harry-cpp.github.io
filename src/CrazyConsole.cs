using System;
using System.Text.RegularExpressions;
using static Retyped.dom;

namespace CrazyWebsite
{
    public static class CrazyConsole
    {
        private static HTMLDivElement _div;

        static CrazyConsole()
        {
            _div = new HTMLDivElement();
            document.body.appendChild(_div);
        }

        public static int InfoSpacing { get; set; }

        public static void WriteLine(string line = string.Empty)
        {
            Write(line + "<br>");
        }

        public static void Write(string text)
        {
            _div.innerHTML += text;
        }

        public static void WriteInfo(string subject, string value)
        {
            WriteLine((subject + ": ").PadRight(InfoSpacing, '.') + " " + value);
        }

        public static void BeginCategory(string title)
        {
            CrazyConsole.WriteLine("[" + title + "]");
            CrazyConsole.WriteLine();
        }

        public static void EndCategory()
        {
            if (!_div.innerHTML.EndsWith("<br><br>"))
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
