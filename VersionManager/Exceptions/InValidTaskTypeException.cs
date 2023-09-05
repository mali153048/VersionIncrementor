
namespace VersionManager.Exceptions
{
    public sealed class InValidTaskTypeException : Exception
    {
        public InValidTaskTypeException()
        {
        }

        public InValidTaskTypeException(string message)
            : base(message)
        {
        }

        public InValidTaskTypeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
