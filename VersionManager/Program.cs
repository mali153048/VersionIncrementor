using VersionManager.Exceptions;
using VersionManager.Services;
using VersionManager.Validator;
using static VersionManager.Enums;

namespace VersionManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VersionService versionService = new VersionService();

                string updatedVersion = versionService.UpdateVersionToFile(args[0]);

                Console.Write("New Version written to file: " + updatedVersion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


        }
    }
}