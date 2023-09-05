
namespace VersionManager.Versions
{
    public sealed class Feature : Version
    {
        public override string GetVersion(string currentVersion)
        {
            var versionParts = currentVersion.Split('.');

            versionParts[2] = (int.Parse(versionParts[2]) + 1).ToString();
            versionParts[3] = "0";

            return string.Join(".", versionParts);
        }
    }
}
