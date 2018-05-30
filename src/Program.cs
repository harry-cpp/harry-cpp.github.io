using System;

namespace CrazyWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            CrazyConsole.InfoSpacing = 16;

            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine("RESUME v1.1.0");
            CrazyConsole.WriteLine("Powered by C#?");
            CrazyConsole.WriteLine("No seriously, check it out: <a href='https://github.com/cra0zy/cra0zy.github.io'>github.com/cra0zy/cra0zy.github.io</a>" );
            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();

            CrazyConsole.BeginCategory("General");
            CrazyConsole.WriteLine("Do note that I'm still a student and that I have only added work stuff that I am proud of.");
            CrazyConsole.WriteLine();
            CrazyConsole.WriteInfo("Username", "cra0zy");
            CrazyConsole.WriteInfo("Nickname", "Harry");
            CrazyConsole.WriteInfo("Name", "Marko Jeremic");
            CrazyConsole.WriteInfo("Mail", "cra0zy@gmail.com");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Social");
            CrazyConsole.WriteInfo("Github", "cra0zy", "https://github.com/cra0zy");
            CrazyConsole.WriteInfo("Twitter", "@cra0zy", "https://twitter.com/cra0zy");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Skillset");
            CrazyConsole.WriteInfo("Languages", "C#, C++, C, Java, Python, Javascript, PHP");
            CrazyConsole.WriteInfo("\"Languages\"", "HTML, CSS, Bash, MySQL, SQL");
            CrazyConsole.WriteLine("");
            CrazyConsole.WriteLine("Other:");
            CrazyConsole.WriteLine(" - Gtk GUI toolkit");
            CrazyConsole.WriteLine(" - Low level Linux programming");
            CrazyConsole.WriteLine(" - Making Android apps (both Xamarin and \"native\" way)");
            CrazyConsole.WriteLine(" - Basics for OpenGL and Vulkan APIs");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Education");
            CrazyConsole.WriteInfo("Highschool", "ETS \"Zemun\"");
            CrazyConsole.WriteInfo("University", "University of Belgrade Faculty of Mathematics (WIP)");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Open Source Work Experience");
            CrazyConsole.WriteWork(
                "MonoGame",
                "MonoGame is an open source implementation of the Microsoft XNA 4 Framework.",
                "I have been a developer on it for a few years, and now I am one of the project maintainers.",
                "http://www.monogame.net/"
            );
            CrazyConsole.WriteWork(
                "Eto.Forms",
                "A cross platform desktop and mobile user interface framework.",
                "I have conributed a lot to the Gtk backend, tho I do contribute to other backends as well.",
                "https://github.com/picoe/Eto"
            );
            CrazyConsole.WriteWork(
                "GtkSharp",
                "NET Standard wrappers for Gtk 3+ and other related libraries.",
                "Since gtk-sharp repo never got to ever releasing a stable 3.0 version for the wrappers, I have decided to take it upon myself to maintain a wrapper set for Gtk 3+ versions.",
                "https://github.com/GtkSharp/GtkSharp"
            );
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Contracted Work Experience");
            CrazyConsole.WriteWork(
                "Raining Blobs",
                "Raining Blobs is 1-16 players, arcade, challenging, falling blobs, puzzle game. Inspired by japanese classics.",
                "I have done the Xbox One port and helped the developer with Mac/Linux ports.",
                "http://rainingblobs.com/",
                "info@rainingblobs.com"
            );
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Personal Projects and Stuff");
            CrazyConsole.WriteWork(
                "Pong",
                "It's just a normal pong, nothing suspicious about it!!!",
                "Yea, this is not normal pong, its a pong that uses a physics engine...  its very addictive, trust me.",
                "https://github.com/cra0zy/Pong/"
            );
            CrazyConsole.WriteWork(
                "Process Monitor",
                "Process Monitor is a simple, Gtk based, process monitor for Linux.",
                "This was a project for my university, it turned out nicely.",
                "https://github.com/MATF-RS18/RS015-process-monitor"
            );
            CrazyConsole.EndCategory();

            CrazyConsole.Flush();
        }
    }
}
