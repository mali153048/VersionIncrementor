
namespace VersionManager.Validator
{
    public static class VersionFormatValidator
    {
        public static bool Validate(string version)
        {
            var versionParts = version.Split('.');

            return versionParts.Length == 4;
        }
    }
}
