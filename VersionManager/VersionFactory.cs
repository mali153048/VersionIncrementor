using VersionManager.Exceptions;
using VersionManager.Versions;
using static VersionManager.Enums;

namespace VersionManager
{
    public sealed class VersionFactory
    {
        public VersionManager.Versions.Version CreateVersion(TaskType type)
        {
            switch (type)
            {
                case TaskType.Feature:
                    return new Feature();
                case TaskType.Bugfix:
                    return new Bugfix();
                case TaskType.None:
                    throw new InValidTaskTypeException(type + " is not a known type.");

                default: throw new InValidTaskTypeException(type + " is not a known type.");
            }
        }
    }
}
