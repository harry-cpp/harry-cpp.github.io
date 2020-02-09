
namespace CrazyWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            CrazyConsole.InfoSpacing = 16;

            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine("RESUME v1.3.1");
            CrazyConsole.WriteLine("Powered by C#?");
            CrazyConsole.WriteLine("No seriously, check it out: <a href='https://github.com/harry-cpp/harry-cpp.github.io'>github.com/harry-cpp/harry-cpp.github.io</a>" );
            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();
            CrazyConsole.WriteLine();

            CrazyConsole.BeginCategory("General");
            CrazyConsole.WriteInfo("Username", "harry-cpp");
            CrazyConsole.WriteInfo("Nickname", "Harry");
            CrazyConsole.WriteInfo("Name", "Marko Jeremic");
            CrazyConsole.WriteInfo("Mail", "cra0zy@gmail.com");
            CrazyConsole.WriteInfo("Github", "harry-cpp", "https://github.com/harry-cpp");
            CrazyConsole.WriteInfo("Twitter", "@harry_cpp", "https://twitter.com/harry_cpp");
            CrazyConsole.WriteInfo("NuGet", "cra0zy", "https://www.nuget.org/profiles/cra0zy");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Education");
            CrazyConsole.WriteInfo("Highschool", "ETS \"Zemun\"");
            CrazyConsole.WriteInfo("University", "University of Belgrade Faculty of Mathematics (WIP)");
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Work Experience");
            CrazyConsole.WriteWork(
                "Two Desperados",
                "Two Desperados is game company that develops zuma style games for mobile (WokaWoka and Violas Quest).",
                "I have been working for Two Desperados since June of 2018 as a Sofrware Engineer.",
                "http://www.twodesperados.com/"
            );
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Contracted Work");
            CrazyConsole.WriteWork(
                "Raining Blobs",
                "Raining Blobs is 1-16 players, arcade, challenging, falling blobs, puzzle game. Inspired by japanese classics.",
                "I have done the Switch and Xbox One ports and helped the developer with Mac and Linux ports.",
                "http://rainingblobs.com/",
                "info@rainingblobs.com"
            );
            CrazyConsole.EndCategory();

            CrazyConsole.BeginCategory("Open Source Work");
            CrazyConsole.WriteWork(
                "MonoGame",
                "MonoGame is an open source implementation of the Microsoft XNA 4 Framework.",
                "I have been a developer on it for a few years, and now I am one of the project maintainers.",
                "http://www.monogame.net/"
            );
            CrazyConsole.WriteWork(
                "GtkSharp",
                "NET Standard wrappers for Gtk 3+ and other related libraries.",
                "Since gtk-sharp repo never got to ever releasing a stable 3.0 version for the wrappers, I have decided to take it upon myself to maintain a wrapper set for Gtk 3+ versions.",
                "https://github.com/GtkSharp/GtkSharp"
            );
            CrazyConsole.WriteWork(
                "Eto.Forms",
                "A cross platform desktop and mobile user interface framework.",
                "I have conributed a lot to the Gtk backend, tho I do contribute to other backends as well.",
                "https://github.com/harry-cpp/code-nautilus"
            );
            CrazyConsole.WriteWork(
                "code-nautilus",
                "Visual Studio Code extension for Nautilus.",
                "There are no \"Open Code Here\" options with Linux file managers so I made my own extension for it.",
                "https://github.com/harry-cpp/code-nautilus"
            );
            CrazyConsole.EndCategory();
            
            CrazyConsole.Flush();
        }
    }
}
