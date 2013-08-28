using System;
using System.Runtime.Serialization;

namespace Exceptionio
{
    /// <summary>
    /// The exception that is thrown when a requested method or operation not found.
    /// </summary>
    [Serializable]
    public class NotFoundException : SystemException
    {
        /// <summary>
        /// Initializes a new instance of the NotFoundException class with
        /// default properties.
        /// </summary>
        public NotFoundException() : base("The method or operation not found.") { }

        /// <summary>
        /// Initializes a new instance of the NotFoundException class with
        /// a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public NotFoundException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the NotFoundException class with
        /// a specified error message and a reference to the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the inner parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public NotFoundException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Initializes a new instance of the NotFoundException class with
        /// serialized data.
        /// </summary>
        /// <param name="info">The System.Runtime.Serialization.SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The System.Runtime.Serialization.StreamingContext that contains contextual information about the source or destination.</param>
        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
