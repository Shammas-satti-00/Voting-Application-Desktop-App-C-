using System.Drawing;
namespace Voting_application
{
    using System.Drawing; // Required for colors

    namespace VotingApplication
    {
        public static class Theme
        {
            public static Color BackgroundColor = Color.LightBlue;
            public static Color ButtonColor = Color.MidnightBlue;
            public static Color ButtonTextColor = Color.White;
            public static Font DefaultFont = new Font("Segoe UI", 10, FontStyle.Regular);
            public static Font TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login_Form());
        }
    }
}