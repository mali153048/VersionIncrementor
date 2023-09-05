using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionManager.Exceptions
{
    public sealed class InValidVersionFormatException : Exception
    {
        public InValidVersionFormatException()
        {
        }

        public InValidVersionFormatException(string message)
            : base(message)
        {
        }

        public InValidVersionFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
