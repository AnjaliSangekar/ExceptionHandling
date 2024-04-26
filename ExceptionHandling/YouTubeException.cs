using System;

namespace ExceptionHandling
{
    public class YouTubeException: Exception 
    {
        public YouTubeException(string message) : base(message)
        {
        }

        //public YouTubeException(string message) : base(message)
        //{
        //}

        public YouTubeException(string message, Exception innerException)
            : base(message, innerException) 
        {
            
        }
    }
}
