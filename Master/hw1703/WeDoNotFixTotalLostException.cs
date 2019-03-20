using System;
using System.Runtime.Serialization;

namespace hw1703
{
    [Serializable]
    public class WeDoNotFixTotalLostException : Exception
    {
        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}