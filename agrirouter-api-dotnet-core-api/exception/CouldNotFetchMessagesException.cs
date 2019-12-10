using System;
using System.Net;

namespace com.dke.data.agrirouter.api.exception
{
    public class CouldNotFetchMessagesException : Exception
    {
        private HttpStatusCode StatusCode { get; }
        private string ErrorMessage { get; }

        public CouldNotFetchMessagesException(HttpStatusCode statusCode, string errorMessage)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
        }

        public override string ToString()
        {
            return $"Could not send message. HTTP status was '{StatusCode}', message content was '{ErrorMessage}'.";
        }
    }
}