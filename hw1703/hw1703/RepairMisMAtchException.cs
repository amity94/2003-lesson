using System;
using System.Runtime.Serialization;

namespace hw1703
{
    [Serializable]
    public class RepairMisMAtchException : Exception
    {
        public RepairMisMAtchException()
        {
        }

        public RepairMisMAtchException(string message) : base(message)
        {
        }

        public RepairMisMAtchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMisMAtchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}