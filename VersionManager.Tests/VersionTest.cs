using VersionManager.Exceptions;
using VersionManager.Services;
using static VersionManager.Enums;

namespace VersionManager.Tests
{
    public sealed class VersionTest
    {
        [Fact]
        public void UpdateVersionWithValidTaskType()
        {
            var versionService = new VersionService();
            var fileService = new FileService();

            fileService.SaveVersionToFile("5.39.9.3");

            string version = versionService.UpdateVersionToFile(TaskType.Feature.ToString());

            Assert.Equal("5.39.10.0", version);
        }

        [Fact]
        public void UpdateVersionWithInValidTaskType()
        {
            var versionService = new VersionService();

            Assert.Throws<InValidTaskTypeException>(() => versionService.UpdateVersionToFile("assdsd"));
        }

        [Fact]
        public void UpdateVersionWithInValidVersionFormat()
        {
            var versionService = new VersionService();
            var fileService = new FileService();

            fileService.SaveVersionToFile("59.3");

            Assert.Throws<InValidVersionFormatException>(() => versionService.UpdateVersionToFile(TaskType.Feature.ToString()));
        }
    }
}