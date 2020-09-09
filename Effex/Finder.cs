using System;
using System.IO;
using System.Linq;

namespace Effex
{
    public static class Finder
    {
        public static string EffectCompilerPath;
        public static bool NeedsToRefind = false;

        public static void Find()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            DigIntoFolder(ref path, ".dotnet");
            DigIntoFolder(ref path, "tools");
            DigIntoFolder(ref path, ".store");
            DigIntoFolder(ref path, "dotnet-mgcb-editor");

            var version = Path.GetFileName(Directory.GetDirectories(path).FirstOrDefault());
            if (String.IsNullOrEmpty(version))
                throw new Exception("`dotnet-mgcb-editor` has no versions installed.");

            DigIntoFolder(ref path, version);
            DigIntoFolder(ref path, "dotnet-mgcb-editor");
            DigIntoFolder(ref path, version);
            DigIntoFolder(ref path, "tools");
            DigIntoFolderish(ref path, "netcore*");
            DigIntoFolder(ref path, "any");

            EffectCompilerPath = Path.Combine(path, "mgfxc.exe");
            if (!File.Exists(EffectCompilerPath))
            {
                throw new Exception("mgfxc.exe was not found.");
            }
        }

        static void DigIntoFolder(ref string currentPath, string target)
        {
            var desiredPath = Path.Combine(currentPath, target);
            if (Directory.Exists(desiredPath))
            {
                currentPath = desiredPath;
            }
            else
            {
                throw new Exception($"`{desiredPath}` does not exist.");
            }
        }
        static void DigIntoFolderish(ref string currentPath, string targetish)
        {
            var possibilities = Directory.GetDirectories(currentPath, targetish);
            if (possibilities.Length == 1)
            {
                if (possibilities[0].Contains('.'))
                {
                    var result = Path.Combine(currentPath, Path.GetFileName(possibilities[0]));
                    currentPath = result;
                }
                else
                {
                    var result = Path.Combine(currentPath, Path.GetDirectoryName(possibilities[0]));
                    currentPath = result;
                }
            }
            else
            {
                throw new Exception($"There were too many or too few possibilities to dig with the search option '{targetish}'");
            }
        }
    }
}
