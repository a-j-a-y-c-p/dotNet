
namespace Assignment1
{
    [Serializable]
    internal class InvalidBasicException : Exception
    {
        public InvalidBasicException()
        {
        }

        public InvalidBasicException(string? message) : base(message)
        {
        }

        public InvalidBasicException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}