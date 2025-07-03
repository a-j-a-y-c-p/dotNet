
namespace Assignment1
{
    [Serializable]
    internal class InvalidEmployeeNumberException : Exception
    {
        public InvalidEmployeeNumberException()
        {
        }

        public InvalidEmployeeNumberException(string? message) : base(message)
        {
        }

        public InvalidEmployeeNumberException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}