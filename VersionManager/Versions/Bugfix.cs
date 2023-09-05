using System;

namespace VersionManager.Versions
{
    public sealed class Bugfix : Version
    {
        public override string GetVersion(string currentVersion)
        {
            var versionParts = currentVersion.Split('.');

            versionParts[3] = (int.Parse(versionParts[3]) + 1).ToString();

            return string.Join(".", versionParts);
        }
    }
}