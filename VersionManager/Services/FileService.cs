namespace VersionManager.Services
{
    public sealed class FileService
    {
        private readonly string _filePath = "C:\\Users\\malif\\Documents\\Repos\\VersionIncrementor\\VersionManager\\ProductInfo.cs";

        public string ReadVersionFromFile()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string? firstLine = File.ReadLines(_filePath).FirstOrDefault();

                    if (!string.IsNullOrWhiteSpace(firstLine))
                    {
                        return firstLine.Trim();
                    }
                    else
                    {
                        throw new Exception("Invalid content in file");
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void SaveVersionToFile(string version)
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    File.WriteAllText(_filePath, version);
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
