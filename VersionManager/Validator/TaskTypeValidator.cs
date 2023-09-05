using System.Threading.Tasks;
using static VersionManager.Enums;

namespace VersionManager.Validator
{
    public static class TaskTypeValidator
    {
        public static bool ValidateAndParse(string taskTypeAsString, out TaskType taskType)
        {
            if(string.IsNullOrWhiteSpace(taskTypeAsString))
            {
                taskType = TaskType.None;
                return false;
            }
                
            if (Enum.TryParse<TaskType>(taskTypeAsString.Trim(), true, out TaskType result))
            {
                taskType = result;
                return true;
            }

            taskType = TaskType.None;
            return false;
        }
    }
}
