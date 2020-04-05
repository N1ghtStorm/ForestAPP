namespace ForestAPI.Errors
{
    // TODO: Make more informative
    /// <summary>
    /// Http Error Message
    /// </summary>
    public class Error
    {
        public Error(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public object Source { get; set; }
    }
}