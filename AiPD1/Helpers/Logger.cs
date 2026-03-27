using System.Diagnostics;

namespace AiPD1.Helpers
{
    internal static class Logger
    {
        public static void WriteLine(string s)
        {
            Debug.WriteLine(s);
        }
    }
}
