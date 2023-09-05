using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersionManager.Exceptions;
using VersionManager.Validator;
using static VersionManager.Enums;
using VersionManager.Versions;

namespace VersionManager.Services
{
    public sealed class VersionService
    {
        private readonly VersionFactory _factory;
        private readonly FileService _fileService;
        public VersionService()
        {
            _factory = new VersionFactory();
            _fileService = new FileService();
        }
        public string UpdateVersionToFile(string type)
        {
            if (TaskTypeValidator.ValidateAndParse(type, out TaskType taskType))
            {
                VersionManager.Versions.Version version = _factory.CreateVersion(taskType);

                var existingVersion = _fileService.ReadVersionFromFile();

                if (VersionFormatValidator.Validate(existingVersion))
                {
                    string updatedVersion = version.GetVersion(existingVersion);

                    _fileService.SaveVersionToFile(updatedVersion);

                    return updatedVersion;
                }
                else
                {
                    throw new InValidVersionFormatException();
                }
            }
            else
            {
                throw new InValidTaskTypeException(type + " is not a known type.");
            }
        }
    }
}
