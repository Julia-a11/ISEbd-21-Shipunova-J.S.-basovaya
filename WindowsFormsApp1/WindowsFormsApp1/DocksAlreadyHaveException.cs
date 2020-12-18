using System;

namespace Laboratornaya
{
    public class DocksAlreadyHaveException : Exception
    {
        public DocksAlreadyHaveException() : base("В доках уже есть такой корабль")
        { }
    }
}