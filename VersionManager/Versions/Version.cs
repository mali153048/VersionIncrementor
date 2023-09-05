using System;

namespace VersionManager.Versions
{
    public abstract class Version
    {
        public abstract string GetVersion(string currentVersion);
    }
}
