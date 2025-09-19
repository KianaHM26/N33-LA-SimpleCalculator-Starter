using System;
using System.Runtime.Serialization;

namespace ClassEngineLibrary
{
    [Serializable]
    internal class NoValidOperations : Exception
    {
        public NoValidOperations()
        {
        }

        public NoValidOperations(string message) : base(message)
        {
        }

        public NoValidOperations(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoValidOperations(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}