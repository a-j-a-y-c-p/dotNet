
namespace Assignment1
{
    [Serializable]
    internal class InvalidDepartmentNumberException : Exception
    {
        public InvalidDepartmentNumberException()
        {
        }

        public InvalidDepartmentNumberException(string? message) : base(message)
        {
        }

        public InvalidDepartmentNumberException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}